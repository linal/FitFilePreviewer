using System;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using FitFilePreviewer.Decode.Dto;
using FitFilePreviewer.Decode.Fit;
using FitFilePreviewer.Decode.Fit.Mesgs;

namespace FitFilePreviewer.Decode
{
    public class Decoder
    {
        private static object _lock = new Object();
        private ActivitySummary data = new ActivitySummary();

        public ActivitySummary Decode(Stream stream)
        {
            Debug.WriteLine("Decoding fit file");
            data = null;
            lock (_lock)
            {
                var decodeDemo = new Fit.Decode();
                var mesgBroadcaster = new MesgBroadcaster();
                decodeDemo.MesgEvent += mesgBroadcaster.OnMesg;
                mesgBroadcaster.SessionMesgEvent += mesgBroadcaster_SessionMesgEvent;

                var status = decodeDemo.IsFIT(stream);
                status &= decodeDemo.CheckIntegrity(stream);

                if (status)
                {
                    decodeDemo.Read(stream);
                }
                else
                {
                    decodeDemo.Read(stream);
                }
            }

            return data;
        }

        void mesgBroadcaster_SessionMesgEvent(object sender, MesgEventArgs e)
        {
            var sessionMessage = (SessionMesg)e.mesg;
            if (sessionMessage != null)
            {
                data = new ActivitySummary();
                data.Sport = sessionMessage.GetSport();
                data.TotalDistance = sessionMessage.GetTotalDistance();
                data.TotalElapsedTime = sessionMessage.GetTotalElapsedTime();
                data.TotalFatCalories = sessionMessage.GetTotalFatCalories();
                data.StartTime = sessionMessage.GetStartTime();
            }
        }
    }
}