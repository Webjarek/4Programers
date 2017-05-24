using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using EmailService.Domain;
using Newsletter.Domain;

namespace Newsletter.Aplication
{
    class Newsletter : INewsletter
    {
        IEmailService _emailService;
        IMessage _message;

        public Newsletter(IEmailService emailService, IMessage message)
        {
            _emailService = emailService;
            _message = message;
        }

        public void Send()
        {
            var TimeNewsletter = new Timer(5648);
            TimeNewsletter.Elapsed += TimeNewsletter_Elapsed;
            
        }

        private void TimeNewsletter_Elapsed(object sender, ElapsedEventArgs e)
        {
            _emailService.Send(_message.Content(), "Jarek@op.pl");
        }
    }
}
