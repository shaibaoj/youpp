using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MoecraftFramework
{
    //定义程序的接口
    public interface IMoePlugin
    {
        string main(string EventType, int subType, int sendTime, int fromGroup, int fromDiscuss, int fromQQ,
        string fromAnonymous, int beingOperateQQ, string msg, int font, string responseFlag, string file);
        string test();
    }
    //控制加载
    public class MoeDllImport
    {
        public class PluginManager
        {
            protected static PluginManager m_PluginManager;
            public static PluginManager GetPluginManager()
            {
                if (m_PluginManager == null)
                {
                    m_PluginManager = new PluginManager();
                }
                return m_PluginManager;
            }

            public List<string> GetPlugins(List<object> compex)
            {
                List<string> commands = new List<string>();
                string pluginFolder = Application.StartupPath+ "\\CSharpDemoTP";
                if (!Directory.Exists(pluginFolder))
                    return commands;
                foreach (string pluginFile in System.IO.Directory.GetFiles(pluginFolder, "*.dll"))
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFile(pluginFile);
                        foreach (Type type in assembly.GetTypes())
                        {
                            if (!type.IsClass || type.IsNotPublic) continue;
                            Type[] tempInterfaces = type.GetInterfaces();
                            if (((IList)tempInterfaces).Contains(typeof(IMoePlugin)))
                            {
                                IMoePlugin plugin = (IMoePlugin)CreateInstance(type);
                                string x = plugin.main(
                                    (string)compex[0],
                                    (int)compex[1],
                                    (int)compex[2],
                                    (int)compex[3],
                                    (int)compex[4],
                                    (int)compex[5],
                                    (string)compex[6],
                                    (int)compex[7],
                                    (string)compex[8],
                                    (int)compex[9],
                                    (string)compex[10],
                                    (string)compex[11]);
                                commands.Add(x);
                            }
                        }
                    }
                    catch
                    {
                    }
                }
                return commands;
            }
            protected object CreateInstance(Type type, object[] args)
            {
                try
                {
                    return Activator.CreateInstance(type, args);
                }
                catch (TargetInvocationException e)
                {
                    throw e.InnerException;
                }
            }
            protected object CreateInstance(Type type)
            {
                return CreateInstance(type, null);
            }
        }
    }
}
