using System;
using System.Collections.Generic;
using System.IO;

namespace Ordi.Files
{
    /// <summary>
    /// 文件处理
    /// </summary>
    public static class OrdiFile
    {
        static OrdiFile()
        {
            LibFiles = GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Library"), "*.dll");
        }

        /// <summary>
        /// Library文件
        /// </summary>
        public static List<FileInfo> LibFiles { get; private set; }


        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <param name="extName">文件扩展名称 如: *.dll, *.jpg. 仅支持一种扩展格式 </param>
        /// <returns></returns>
        public static List<FileInfo> GetFiles(string path, string extName = "*")
        {
            var result = new List<FileInfo>();

            try
            {
                string[] dirs = Directory.GetDirectories(path);
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles(extName);
                if (files.Length != 0)
                {
                    result.AddRange(files);
                }
                if (dirs.Length != 0)
                {
                    foreach (string dirPath in dirs)
                    {
                        result.AddRange(GetFiles(dirPath, extName));
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.Error("获取文件错误", ex);
                return result;
            }

            return result;
        }
    }
}
