using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Common
{
    public class SpeechPlay
    {
        public static void SpeakContent(string content,int delay=400)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SpeakAsync(content);            
            Task.Delay(delay * content.Count());
        }
    }
}
