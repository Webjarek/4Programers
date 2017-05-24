using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newsletter.Domain;

namespace Newsletter.Domain
{
    class Message : IMessage
    {
        IMessageRepository _repo;

        public Message(IMessageRepository repo)
        {
            _repo = repo;
        }

        public string Content()
        {
            return String.Format("This is a content of message:{0}", _repo.Content());
        }
    }
}
