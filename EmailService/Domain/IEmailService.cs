using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService.Domain
{
    public interface IEmailService
    {
        void Send(string context, string toEmail);
    }
}
