using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordi.Browser.BrowserHandlers
{
    internal sealed class BrowserBound
    {
        private OrdiBrowser Browser { get; set; }
        public BrowserBound(OrdiBrowser ordi)
        {
            Browser = ordi;
        }

        /// <summary>
        /// 异步调用:JS调用.Net方法,返回值,回调JS方法
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        /// <param name="callBack"></param>
        public void ExecuteAsyncCallBack(string args1, string args2, string args3, IJavascriptCallback callBack)
        {
            Task.Factory.StartNew(async () =>
            {
                using (callBack)
                {
                    var result = Browser.ExecuteAsyncCallBack(args1, args2, args3);
                    await callBack.ExecuteAsync(result);
                }
            });
        }

        /// <summary>
        /// JS调用.Net方法,返回值,无回调
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        public string ExecuteCall(string args1, string args2, string args3)
        {
            return Browser.ExecuteCall(args1, args2, args3);
        }

        /// <summary>
        /// JS调用.Net方法,无返回值,无回调
        /// </summary>
        /// <param name="args1"></param>
        /// <param name="args2"></param>
        /// <param name="args3"></param>
        public void DirectExecute(string args1, string args2, string args3)
        {
            Browser.DirectExecute(args1, args2, args3);
        }
    }
}
