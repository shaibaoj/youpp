using System;
using System.Runtime.InteropServices;
using System.Text;

namespace jk
{
	public class Dama2
	{
		public const int ERR_CC_SUCCESS = 0;

		public const int ERR_CC_SOFTWARE_NAME_ERR = -1;

		public const int ERR_CC_SOFTWARE_ID_ERR = -2;

		public const int ERR_CC_FILE_URL_ERR = -3;

		public const int ERR_CC_COOKIE_ERR = -4;

		public const int ERR_CC_REFERER_ERR = -5;

		public const int ERR_CC_VCODE_LEN_ERR = -6;

		public const int ERR_CC_VCODE_TYPE_ID_ERR = -7;

		public const int ERR_CC_POINTER_ERROR = -8;

		public const int ERR_CC_TIMEOUT_ERR = -9;

		public const int ERR_CC_INVALID_SOFTWARE = -10;

		public const int ERR_CC_COOKIE_BUFFER_TOO_SMALL = -11;

		public const int ERR_CC_PARAMETER_ERROR = -12;

		public const int ERR_CC_USER_ALREADY_EXIST = -100;

		public const int ERR_CC_BALANCE_NOT_ENOUGH = -101;

		public const int ERR_CC_USER_NAME_ERR = -102;

		public const int ERR_CC_USER_PASSWORD_ERR = -103;

		public const int ERR_CC_QQ_NO_ERR = -104;

		public const int ERR_CC_EMAIL_ERR = -105;

		public const int ERR_CC_TELNO_ERR = -106;

		public const int ERR_CC_DYNC_VCODE_SEND_MODE_ERR = -107;

		public const int ERR_CC_INVALID_CARDNO = -108;

		public const int ERR_CC_DYNC_VCODE_OVERFLOW = -109;

		public const int ERR_CC_DYNC_VCODE_TIMEOUT = -110;

		public const int ERR_CC_USER_SOFTWARE_NOT_MATCH = -111;

		public const int ERR_CC_NEED_DYNC_VCODE = -112;

		public const int ERR_CC_NOT_LOGIN = -201;

		public const int ERR_CC_ALREADY_LOGIN = -202;

		public const int ERR_CC_INVALID_REQUEST_ID = -203;

		public const int ERR_CC_INVALID_VCODE_ID = -204;

		public const int ERR_CC_NO_RESULT = -205;

		public const int ERR_CC_NOT_INIT_PARAM = -206;

		public const int ERR_CC_ALREADY_INIT_PARAM = -207;

		public const int ERR_CC_SOFTWARE_DISABLED = -208;

		public const int ERR_CC_NEED_RELOGIN = -209;

		public const int EER_CC_ILLEGAL_USER = -210;

		public const int EER_CC_REQUEST_TOO_MUCH = -211;

		public const int ERR_CC_CONFIG_ERROR = -301;

		public const int ERR_CC_NETWORK_ERROR = -302;

		public const int ERR_CC_DOWNLOAD_FILE_ERR = -303;

		public const int ERR_CC_CONNECT_SERVER_FAIL = -304;

		public const int ERR_CC_MEMORY_OVERFLOW = -305;

		public const int ERR_CC_SYSTEM_ERR = -306;

		public const int ERR_CC_SERVER_ERR = -307;

		public const int ERR_CC_VERSION_ERROR = -308;

		public const int ERR_CC_READ_FILE = -309;

		public Dama2()
		{
		}

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int ChangeInfo(string pUserOldPassword, string pUserNewPassword, string pszQQ, string pszTelNo, string pszEmail, string pszDyncVCode, int nDyncSendMode);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int D2Balance(string pszSoftwareID, string pszUserName, string pszUswrPassword, ref uint pulBalance);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int D2Buf(string pszSoftwareID, string pszUserName, string pszUswrPassword, byte[] pImageData, uint dwDataLen, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int D2File(string pszSoftwareID, string pszUserName, string pszUswrPassword, string pszFileName, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Decode(string pszFileURL, string pszCookie, string pszReferer, byte ucVerificationCodeLen, ushort usTimeout, uint ulVCodeTypeID, int bDownloadPictureByLocalMachine, ref uint pulRequestID);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeBuf(byte[] pImageData, uint dwDataLen, string pszExtName, byte ucVerificationCodeLen, ushort usTimeout, uint ulVCodeTypeID, ref uint pulRequestID);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeBufSync(byte[] pImageData, uint dwDataLen, string pszExtName, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeFileSync(string pszFileName, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeSync(string pszFileURL, string pszCookie, string pszReferer, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText, StringBuilder pszRetCookie);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeWnd(string pszWndDef, ref RECT lpRect, byte ucVerificationCodeLen, ushort usTimeout, uint ulVCodeTypeID, ref uint pulRequestID);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int DecodeWndSync(string pszWndDef, ref RECT lpRect, ushort usTimeout, uint ulVCodeTypeID, StringBuilder pszVCodeText);

		[DllImport("Plugin\\Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int GetOrigError();

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int GetResult(uint ulRequestID, uint ulTimeout, StringBuilder pszVCode, uint ulVCodeBufLen, ref uint pulVCodeID, StringBuilder pszReturnCookie, uint ulCookieBufferLen);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Init(string softwareName, string softwareID);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Login(string pszUserName, string pszUserPassword, string pDyncVerificationCode, StringBuilder pszSysAnnouncementURL, StringBuilder pszAppAnnouncementURL);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Login2(string pszUserName, string pszUserPassword);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Logoff();

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int QueryBalance(ref uint pulBalance);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int ReadInfo(StringBuilder pszUserName, StringBuilder pszQQ, StringBuilder pszTelNo, StringBuilder pszEmail, ref int pDyncSendMode);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Recharge(string pszUserName, string pszCardNo, ref uint pulBalance);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int Register(string pszUserName, string pszUserPassword, string pszQQ, string pszTelNo, string pszEmail, int nDyncSendMode);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern int ReportResult(uint ulVCodeID, int bCorrect);

		[DllImport("Plugin\\CrackCaptchaAPI.dll", CharSet=CharSet.Ansi, ExactSpelling=false)]
		public static extern void Uninit();
	}
}