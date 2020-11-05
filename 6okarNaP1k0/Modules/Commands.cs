using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _6okarNaP1k0.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("kaksi")]
        public async Task KakSi()
        {
            await ReplyAsync("6okar sym tenk u");        
        }

        [Command("laho")]
        public async Task Laho()
        {
            Random random = new Random();
            var id = random.Next(1, 100) % 3;
            if (id == 0)
            {
                await Context.Channel.SendFileAsync("piko1.jpeg", "Na ti chubrica, gevreishyn!");
            }
            else if (id == 1)
            {
                await Context.Channel.SendFileAsync("piko2.png", "p1k0 de, ama nikoi nqq po - dylga liniq ot moqta!");
            }
            else
            {
                await Context.Channel.SendFileAsync("piko3.jpg", "Nai - dobroto maka6i!");
            }
        }

        [Command("rechnik")]
        public async Task Rechnik()
        {
            await ReplyAsync("Q gledai tuka e i dav tu bule, sekish! \n https://www.bgjargon.com/wordlist/tag/%D1%86%D0%B8%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%B8");
        }

        [Command("pomagai")]
        public async Task Pomagai()
        {
            StringBuilder message = new StringBuilder();
            message.AppendLine("Geldim, qsha batko! Q moga:\n");
            message.AppendLine("Prefixa e \'!p1k0\', ne go zabraai!");
            message.AppendLine("Ako sh mi pravish bibitki, pitai ma \'kaksi\'");
            message.AppendLine("Ako sakash iznenada samo si poiskai s \'laho\'");
            message.AppendLine("Ako si smotan i ne znaesh ciganski, glei u \'rechnik\'");
            await ReplyAsync(message.ToString());
        }
    }
}
