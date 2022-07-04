using System;
using System.Globalization;

namespace Datas
{
    class Program
    {

        static void Aula1(){
            // var data = new DateTime();
            // var data = DateTime.Now;
            // Console.WriteLine(data);
        }
        static void Aula2(){
            var data = new DateTime(2020, 10, 12, 13, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            Console.WriteLine(data.DayOfWeek);
            Console.WriteLine((int)data.DayOfWeek);
            Console.WriteLine(data.DayOfYear);
        }

        static void Aula3(){
            var data = DateTime.Now;

            var formatada = String.Format("{0}", data);
            // var formatada = String.Format("{0:yyyy}", data); // só o ano
            // var formatada = String.Format("{0:yyyy-MM-dd}", data); // só o ano, mes, dia
            // var formatada = String.Format("{0:yyyy *** MM *** dd}", data); // só o ano, mes, dia
            // var formatada = String.Format("{0:yyyy/MM/dd}", data); // só o ano, mes, dia
            // var formatada = String.Format("{0:dd/MM/yyyy}", data); // só o ano, mes, dia
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data); // só o ano, mes, dia
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss ff z}", data); // só o ano, mes, dia ff- fração de segundo z|zz|zzz-timezone ex: (utc-3)
            Console.WriteLine(formatada);
        }

        static void Aula4(){
            var data = DateTime.Now;
            var formatada = String.Format("{0:D}", data); // segunda-feira, 4 de julho de 2022
            Console.WriteLine(formatada);
            formatada = String.Format("{0:f}", data); // segunda-feira, 4 de julho de 2022 09:41
            Console.WriteLine(formatada);
            formatada = String.Format("{0:g}", data); // 04/07/2022 09:41
            Console.WriteLine(formatada);
            formatada = String.Format("{0:r}", data); // Mon, 04 Jul 2022 09:41:43 GMT
            Console.WriteLine(formatada);
            formatada = String.Format("{0:s}", data); // 2022-07-04T09:41:43
            Console.WriteLine(formatada);
            formatada = String.Format("{0:u}", data); // 2022-07-04 09:41:43Z
            Console.WriteLine(formatada);
        }
        
        static void Aula5(){
            Console.Clear();
            var data = DateTime.Now;
            // var dia = data.Day + 1; // evitar usar desse jeito
            
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddYears(12));
        }
        
        static void Aula6(){
            Console.Clear();

            var data = DateTime.Now;
            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
        }

        static void Aula7(){
            Console.Clear();
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var us = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;


            // Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", us));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            // Console.WriteLine(string.Format("{0:D}", DateTime.Now));
        }

        static void Aula8(){
            Console.Clear();
            var dateTime = DateTime.UtcNow;
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToLocalTime());

            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);
            // var horaAustralia = TimeZoneInfo.ConvertTimeToUtc(dateTime, ),
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var tz in timezones)
            {
                Console.WriteLine(tz);
                Console.WriteLine(tz.Id);
                // Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc());
            }
        }

        static void Aula9(){
            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanHoraMinutoSegundo);
            Console.WriteLine(timeSpanHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        }

        static void Main(string[] args)
        {
            Aula9();
        }
    }
}
