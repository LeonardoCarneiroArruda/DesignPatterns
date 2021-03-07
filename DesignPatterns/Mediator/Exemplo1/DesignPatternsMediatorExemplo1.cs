using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exemplo1
{
    public class DesignPatternsMediatorExemplo1 : IDesignPatterns
    {
        public void MainExemplo()
        {
            ChatSala chatSala = new ChatSala();

            Participante Macoratti = new Membro("Macoratti");
            Participante Miriam = new Membro("Miriam");
            Participante Jefferson = new Membro("Jefferson");
            Participante Janice = new Membro("Janice");
            Participante Jessica = new NaoMembro("Jessica");

            chatSala.Registro(Macoratti);
            chatSala.Registro(Miriam);
            chatSala.Registro(Jefferson);
            chatSala.Registro(Janice);
            chatSala.Registro(Jessica);

            Jessica.Enviar("Janice", "Olá, Janice!");
            Miriam.Enviar("Jefferson", "Como vai você");
            Jefferson.Enviar("Macoratti", "Tudo bem");
            Miriam.Enviar("Janice", "Como você esta ?");
            Janice.Enviar("Jessica", "Tudo tranquilo...");
        }
    }
}
