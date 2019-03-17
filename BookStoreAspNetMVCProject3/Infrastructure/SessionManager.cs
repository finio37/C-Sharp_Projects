using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
namespace ProjektKsiegarniBCity.Infrastructure
{
    public class SessionManager : ISessionManager
    {
        private HttpSessionState _session;
        public SessionManager()
        {
            _session = HttpContext.Current.Session;
        }
        public void Abandon()
        {
            _session.Abandon();
            //anuluje bierzącą sesję
            //throw new NotImplementedException();
        }
        public T Get<T>(string key)
        {
            return (T)_session[key];
            //zwraca stan bierzacej sesji

            //throw new NotImplementedException();
        }
        public T Get<T>(string key, Func<T> createDefault)
        {
            T retVal;
            if (_session[key] != null && _session[key].GetType() == typeof(T))
            {
                retVal = (T)_session[key];
            }
            else
            {
                retVal = createDefault();
                _session[key] = retVal;
            }
            return retVal;
            //throw new NotImplementedException();
        }
        public void Set<T>(string name, T value)
        {
            _session[name] = value;
            //ustawia sesję
           // throw new NotImplementedException();
        }
        public T TryGet<T>(string key)
        {
            try
            {
                return (T)_session[key];

            }
            catch (NullReferenceException)
            {
                return default(T);
            }


            //throw new NotImplementedException();
        }
    }
}