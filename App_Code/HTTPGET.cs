using System;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using System.Net;

namespace Warface
{
    /// <summary>
    /// Сервер варфейса
    /// </summary>
    public enum Server
    {
        Альфа = 1,
        Браво = 2,
        Чарли = 3
    }
 
    /// <summary>
    /// Класс запрпоса данных с сервера
    /// </summary>
    public class HTTPGET
    {
        public HTTPGET() { }
        const string ApiUrl = "http://api.warface.ru";

        /// <summary>
        /// Полечение информации о персонаже Warface
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public static object GetUserInfo(string UserName, Server SR )
        {
            if (UserName.Length == 0) { throw new System.ArgumentException("Имя пользоваателя пустое"); }
            string url = ApiUrl + "/user/stat/?name=" + UserName + "&server="+SR.GetHashCode();
            object value = null;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                myHttpWebRequest.Method = "GET";
                myHttpWebRequest.Accept = "text/html";
                myHttpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
                myHttpWebRequest.Headers.Add("Accept-Language", "ru-RU");
                myHttpWebRequest.KeepAlive = false;
                myHttpWebRequest.Host = "api.warface.ru";
                myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586";
                myHttpWebRequest.AllowAutoRedirect = false;
                using (HttpWebResponse req = (HttpWebResponse)myHttpWebRequest.GetResponse())
                {
                    using (System.IO.Stream stream = req.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(stream, true);
                            try
                            {
                                value = JsonConvert.DeserializeObject<UserInfo>(sr.ReadToEnd());
                            }
                            catch (JsonException Jerr)
                            {
                                throw new System.ArgumentException("Ошибка расшифровки ответа JSON от сервера: "+Jerr.Message); 
                            }
                            sr.Close();
                        }
                        stream.Close();
                    }
                    req.Close();
                }
            }
            catch (WebException err)
            {
                if (err.Status == WebExceptionStatus.ProtocolError)
                {
                    using (System.IO.Stream stream = err.Response.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            System.IO.StreamReader sr = new System.IO.StreamReader(stream, true);
                            try
                            {
                                value = JsonConvert.DeserializeObject<ErrorInfo>(sr.ReadToEnd());
                            }
                            catch ( JsonException Jerr)
                            {
                                throw new System.ArgumentException("Ошибка расшифровки ответа JSON от сервера: " + Jerr.Message); 
                            }
                            sr.Close();
                        }
                    }
                }
                if (err.Status == WebExceptionStatus.CacheEntryNotFound) { throw new System.ArgumentException("Ошибка соединенения: Указанная запись не была найдена в кэше"); }
                if (err.Status == WebExceptionStatus.ConnectFailure) { throw new System.ArgumentException("Ошибка соединенения: С точкой удаленной службы нельзя связаться на транспортном уровне"); }
                if (err.Status == WebExceptionStatus.ConnectionClosed) { throw new System.ArgumentException("Ошибка соединенения: Подключение было преждевреммно закрыто"); }
                if (err.Status == WebExceptionStatus.KeepAliveFailure) { throw new System.ArgumentException("Ошибка соединенения: Неожиданно закрыто подключение для запроса, задающего загаловок Keep-alive"); }
                if (err.Status == WebExceptionStatus.MessageLengthLimitExceeded) { throw new System.ArgumentException("Ошибка соединенения: Принято сообщение о превышении заданного ограничения при передаче запроса или приеме ответа сервера"); }
                if (err.Status == WebExceptionStatus.NameResolutionFailure) { throw new System.ArgumentException("Ошибка соединенения: Служба разрешения имен не можеть разрешить имя узла"); }
                if (err.Status == WebExceptionStatus.Pending) { throw new System.ArgumentException("Ошибка соединенения: Внутренний асинхронный запрос находиться в очереди"); }
                if (err.Status == WebExceptionStatus.PipelineFailure) { throw new System.ArgumentException("Ошибка соединенения: Запрос являлся конвеерным запросом и подключение было закрыто до получения запроса"); }
                if (err.Status == WebExceptionStatus.ProxyNameResolutionFailure) { throw new System.ArgumentException("Ошибка соединенения: Служба разрешения имен не может распознать имя узла проски сервера"); }
                if (err.Status == WebExceptionStatus.ReceiveFailure) { throw new System.ArgumentException("Ошибка соединенения: От удаленного сервера не был получен полный ответ"); }
                if (err.Status == WebExceptionStatus.RequestCanceled) { throw new System.ArgumentException("Ошибка соединенения: Запрос был отменен"); }
                if (err.Status == WebExceptionStatus.RequestProhibitedByCachePolicy) { throw new System.ArgumentException("Ошибка соединенения: Запрос не разрешен политикой кеширования"); }
                if (err.Status == WebExceptionStatus.RequestProhibitedByProxy) { throw new System.ArgumentException("Ошибка соединенения: Этот запрос не разрешен прокси сервером"); }
                if (err.Status == WebExceptionStatus.SendFailure) { throw new System.ArgumentException("Ошибка соединенения: Полный запрос не был передан на удаленный сервер"); }
                if (err.Status == WebExceptionStatus.ServerProtocolViolation) { throw new System.ArgumentException("Ошибка соединенения: Ответ сервера не являлся допустимым ответом HTTP"); }
                if (err.Status == WebExceptionStatus.Timeout) { throw new System.ArgumentException("Ошибка соединенения: В течение времени времени ожидания ответ получен не был"); }
                if (err.Status == WebExceptionStatus.TrustFailure) { throw new System.ArgumentException("Ошибка соединенения: Сертификат сервера не может быть проверен"); }
                if (err.Status == WebExceptionStatus.UnknownError) { throw new System.ArgumentException("Ошибка соединенения: Возникло исключение не известного типа"); }
            }
            return value;
        }
    }

}