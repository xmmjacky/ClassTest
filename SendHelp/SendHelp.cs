using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SendHelp
{
  public  class SendHelp
    {
        public static void SendEmail(string strSubject, string strMailContent, string strMailTo, string strCopySend, string strPath,
        MailPriority priority)
        {
            var mMsg = new MailMessage();
            var smtp = new SmtpClient() ;
            smtp.Host = "smtp.163.com";
            smtp.Port = 25;            
            smtp.EnableSsl = false;           
            smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;

            smtp.Credentials = new System.Net.NetworkCredential("xinmingming0629", "jsxmm629043");
            //smtp.UseDefaultCredentials = true;
            //加入
            mMsg.Headers.Add("X-Priority", "3");
            mMsg.Headers.Add("X-MSMail-Priority", "Normal");
            mMsg.Headers.Add("X-Mailer", "Microsoft Outlook Express 6.00.2900.2869");
            mMsg.Headers.Add("X-MimeOLE", "Produced By Microsoft MimeOLE V6.00.2900.2869");

            mMsg.SubjectEncoding = Encoding.UTF8;

            mMsg.Subject = strSubject;

            mMsg.BodyEncoding = Encoding.UTF8;
            mMsg.IsBodyHtml = true;
            mMsg.Body = strMailContent;
            if (strPath != "" && strPath != null)
            {
                mMsg.Attachments.Add(new Attachment(strPath));
            }
            mMsg.Priority = priority;
            string[] mailto = strMailTo.Split(',');
            foreach (string str in mailto)
            {
                if (str != "")
                {
                    mMsg.To.Add(new MailAddress(str));
                }
            }

            string[] MailCopySend = strCopySend.Split(',');
            foreach (string copySend in MailCopySend)
            {
                if (copySend != "")
                {
                    mMsg.CC.Add(new MailAddress(copySend));
                }
            }

            smtp.Send(mMsg);
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        public static void SendMail(string strSubject,string strMailContent,string strMailTo,string strCopySend)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            //msg.To.Add("lcvfb@qq.com");
            msg.To.Add(strMailTo);

            // msg.To.Add("b@b.com");
            //可以发送给多人 

            //msg.CC.Add("c@c.com");
            //可以抄送给多人 

            msg.From = new MailAddress("xinmingming@aidaijia.com", "爱代驾", System.Text.Encoding.UTF8);/* 上面3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/
            msg.Subject = strSubject;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码 
            msg.Body = strMailContent;
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码 
            msg.IsBodyHtml = true;//是否是HTML邮件 
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("xinmingming@aidaijia.com", "jsxmm629043"); 
            client.Host = "smtp.qq.com";
            try
            {
                client.Send(msg);
               
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                throw ex;
            }
        }
    }
}
