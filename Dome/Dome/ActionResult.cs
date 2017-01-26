using System;
using System.Collections.Generic;
using System.Linq;

namespace Dome
{

    public enum MessageType
    {
        Error = 1,
        Warning = 2,
        Information = 4,
        Success = 8,
    }
    public class Message
    {
        public Message(MessageType type, string message)
        {
            Content = message;
            Type = type;
        }

        public Message(MessageType type, string format, params object[] args)
        {
            Content = args != null ? string.Format(new PluralFormatProvider(), format, args) : format;
            Type = type;
        }

        public string Content { get; set; }

        public MessageType Type { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Type, Content);
        }

        public class PluralFormatProvider : IFormatProvider, ICustomFormatter
        {
            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (format == null || format.StartsWith("#") == false)
                {
                    var formattableArg = arg as IFormattable;


                    if (formattableArg != null)
                    {
                        return formattableArg.ToString(format, formatProvider);
                    }


                    return arg != null ? arg.ToString() : null;
                }

                string[] forms = format.Remove(0, 1).Split(';');
                var value = (int)arg;
                int form = value == 1 ? 0 : 1;

                return forms[form];
            }

            public object GetFormat(Type formatType)
            {
                return this;
            }
        }
    }
    public class ActionResult
    {
        internal ActionResult()
        {
            Messages = new Message[0];
        }

        public ActionResult(bool succeeded)
        {
            Succeeded = succeeded;
            Messages = new Message[0];
        }

        public ActionResult(bool succeeded, IEnumerable<Message> messages)
        {
            Succeeded = succeeded;
            Messages = messages != null ? messages.ToArray() : new Message[0];
        }

        public ActionResult(bool succeeded, params Message[] messages)
        {
            Succeeded = succeeded;
            Messages = messages;
        }

        public bool Succeeded { get; set; }

        public Message[] Messages { get; protected set; }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, (object[])Messages);
        }
    }
    public class ActionResult<T> : ActionResult
    {
        public ActionResult(bool succeeded, T entity)
        {
            Succeeded = succeeded;
            Entity = entity;
        }

        public ActionResult(bool succeeded, T entity, IEnumerable<Message> messages)
        {
            Succeeded = succeeded;
            Entity = entity;
            Messages = messages != null ? messages.ToArray() : new Message[0];
        }

        public ActionResult(bool succeeded, T entity, params Message[] messages)
        {
            Succeeded = succeeded;
            Entity = entity;
            Messages = messages;
        }

        public T Entity { get; set; }
    }


}
