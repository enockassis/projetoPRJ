using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace CAIXA
{
    public sealed class LeitorDeTexto
    {
        private SpeechSynthesizer synthesizer;

        private static readonly LeitorDeTexto instancia = new LeitorDeTexto();

        private LeitorDeTexto()
        {
            synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Adult, 0, new System.Globalization.CultureInfo("pt-BR"));
        }

        public static LeitorDeTexto Instancia
        {
            get
            {
                return instancia;
            }
        }

        public void Falar(string text)
        {
            Prompt prompt = new Prompt(text, SynthesisTextFormat.Text);
            
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.SpeakAsyncCancelAll();
            }
            synthesizer.SpeakAsync(prompt);
        }
    }
}
