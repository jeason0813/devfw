﻿/*
 * 由SharpDevelop创建。
 * 用户： newmin
 * 日期: 2013/11/19
 * 时间: 21:35
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System.Web;

namespace Com.PluginKernel.Web
{
	/// <summary>
	/// Description of HandleRequest.
	/// </summary>
	public class RequestProxry
	{
        private IExtendPluginHost app;
        private static IPluginRequestHandler handler = new RequestHandle();
		public RequestProxry(IExtendPluginHost host,IPluginRequestHandler handler)
		{
			this.host=host;
            this.handler = handler;
		}
		
		public void HandleGet(HttpContext context,ref bool handled)
		{
            if (host.HanleRequestUse<IPluginRequestHandler>(handler, context, false))
            {
                handled = true;
            }
		}
		
		public void HandlePost(HttpContext context,ref bool handled)
		{
            if (host.HanleRequestUse<RequestHandle>(handler, context, true))
            {
                handled = true;
            }
		}


        public IPluginHost host { get; set; }
    }
}
