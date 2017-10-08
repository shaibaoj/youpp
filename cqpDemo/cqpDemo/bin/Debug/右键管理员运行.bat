@echo off
title moecraft
echo  使用前请安装.NetFramework4.0以上版本的运行库
echo 【1】   注册类型
echo 【2】   注销类型
choice /c:12
if errorlevel 2 goto unreg
if errorlevel 1 goto reg
pause
:reg
echo  现在开始对cqlib.dll进行注册
set hh=%~dp0&if "!hh:~-1!"=="\" set hh=!hh:~,-1!
path %hh%
cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
RegAsm.exe cqlib.dll
pause
goto exit
:unreg
echo  现在开始对cqlib.dll进行注销
set hh=%~dp0&if "!hh:~-1!"=="\" set hh=!hh:~,-1!
path %hh%
cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
RegAsm.exe /u cqpDemo.dll
pause
:exit