using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RSV_StartYourGame_JuniorLevel10
{
    class MainClass
    {
        //n – количество участников, а m – количество кругов трассы. 
        static int n = 19;
        static int m = 9;

        static List<double> BesheniyKlop = new List<double>{
        19.631569587265083, 11.18925901144337, 15.91344395071013, 12.154182168716279, 8.81432000517714, 8.50449427692515, 16.051245186807506, 10.466681872013751, 13.93441990853402
        };

        static List<double> BoltlivijPon4ik = new List<double>{
        11.019291673323359, 16.83485272244974, 14.485103324401884, 9.337684423847161, 10.271210279573754, 6.455913239699237, 12.901410039195529, 17.796852129901794, 13.116418911063704
        };

        static List<double> Kokos_tebe_v_nos = new List<double>{
        5.98656731372628, 12.63684121562483, 19.247690830167667, 12.38576453960481, 9.530496906795191, 17.893596456510508, 12.390750397708748, 10.801224025376808, 13.201255203380445
        };

        static List<double> DirkaOtBublika = new List<double>{
        9.163282201823288, 16.40482017542884, 14.30212172625473, 7.719982294934643, 14.298581521460111, 7.275549313130668, 9.584990970537493, 15.825595293216157, 10.630764231467738
        };

        static List<double> E4po4mak = new List<double>{
        18.59799894255959, 10.343788043827894, 15.279126958311886, 5.91286195734542, 16.08033624119515, 13.900115478331715, 15.875367817412862, 10.53274187627396, 19.912700380559492
        };

        static List<double> dwaHolma = new List<double>{
        11.06456002887833, 18.355675491171585, 7.108713545311316, 6.7156703814649, 8.144078160522792, 17.540313992820614, 11.080165725190657, 9.925555721449996, 15.107430697152264
        };

        static List<double> homjakVnore = new List<double>{
        15.577512622841848, 12.758807871354298, 5.324157771763595, 15.192983798889703, 13.3779655866763, 13.542092025070732, 13.30206564030273, 6.2024807227142995, 18.710176562323547
        };

        static List<double> chebuRek = new List<double>{
        12.372660958952858, 5.820423159659261, 15.860499702153337, 6.773620509961004, 12.330451997906652, 10.100292749882591, 9.645333237104737, 18.433981889643228, 10.54574689230298
        };

        static List<double> ZaikaBabaika = new List<double>{
        14.294986472656646, 8.082564906358884, 5.519447535710204, 10.755256236459925, 14.22576740656434, 9.371380953608764, 19.7392332826769, 7.532087720147903, 9.30706929931808
        };

        static List<double> Bazinga = new List<double>{
        14.085327433910185, 10.060293286245493, 13.189645330122307, 11.335816275901617, 12.79662829444188, 12.464905266203836, 18.22990603423611, 19.183680736439648, 11.530773089900155
        };

        static List<double> dwaHolma_2 = new List<double>{
        10.932055841595854, 10.415709770814999, 5.365793110371466, 14.84143782669116, 12.485746698595182, 17.39626690610156, 6.97704397302344, 16.68634114961054, 10.666906121826248
        };

        static List<double> MohnatieNogi = new List<double>{
        14.097052584630413, 8.991441996689428, 16.393114056309184, 12.776209565047521, 5.240029380140136, 14.346313628156912, 6.973164603343818, 17.295363365107498, 18.6383850041711
        };

        static List<double> GordijElf = new List<double>{
        13.118992793647248, 6.9528733224211425, 17.208396127900187, 19.822055720662004, 17.31680579850799, 7.515510887502385, 7.166685067091774, 5.542119890584344, 8.230168578553974
        };

        static List<double> BodriyLiniveZ = new List<double>{
        10.043130250104312, 9.486022324377032, 15.202330186607167, 11.34677641417958, 13.909546241783998, 16.445247383607708, 10.255855931454468, 9.045042810857032, 16.418599061128475
        };

        static List<double> SpontannijTwerk = new List<double>{
        18.736265212216296, 5.791926409015568, 9.780821717912929, 10.73168388521211, 14.714022807710432, 5.643269968131604, 15.235216550165505, 18.24944559930621, 7.057049339236123
        };

        static List<double> UtkonosPoteetMolokom = new List<double>{
        13.08897460653628, 18.983198143371986, 15.756136535332102, 6.750488704349331, 12.468992812364416, 18.416096822726622, 11.313830680867788, 6.54247126962855, 6.681469459226918
        };

        static List<double> Enot_poloskyn = new List<double>{
        19.44217574199208, 17.562802321239786, 8.398881459966328, 16.947702988541714, 12.71145499396199, 18.801675159679252, 8.783755786268062, 5.291578544734844, 14.558299215819048
        };

        static List<double> kuKAreKU = new List<double>{
        5.5638608791890585, 5.816575329882249, 17.99941140386166, 9.815983687054999, 7.368909678635927, 5.747287148498174, 14.64349101279976, 12.706781595564983, 17.946530175432343
        };

        static List<double> BoltlivijPon4ik_2 = new List<double>{
        13.625827180894253, 17.956662205672128, 14.143502750335145, 6.704899039793394, 8.48805494588806, 14.18349807985684, 7.57698491159997, 16.490034732079174, 17.198829563923923
        };

        public static void Main(string[] args)
        {

            double BesheniyKlop_sum = BesheniyKlop.Sum();
            Console.WriteLine("BesheniyKlop_sum: " + BesheniyKlop_sum);

            double BoltlivijPon4ik_sum = BoltlivijPon4ik.Sum();
            Console.WriteLine("BoltlivijPon4ik sum: " + BoltlivijPon4ik_sum);

            double Kokos_tebe_v_nos_sum = Kokos_tebe_v_nos.Sum();
            Console.WriteLine("Kokos_tebe_v_nos sum: " + Kokos_tebe_v_nos_sum);

            double DirkaOtBublika_sum = DirkaOtBublika.Sum();
            Console.WriteLine("DirkaOtBublika sum: " + DirkaOtBublika_sum);

            double E4po4mak_sum = E4po4mak.Sum();
            Console.WriteLine("E4po4mak sum: " + E4po4mak_sum);

            double dwaHolma_sum = dwaHolma.Sum();
            Console.WriteLine("dwaHolma sum: " + dwaHolma_sum);

            double homjakVnore_sum = homjakVnore.Sum();
            Console.WriteLine("homjakVnore sum: " + homjakVnore_sum);

            double chebuRek_sum = chebuRek.Sum();
            Console.WriteLine("chebuRek sum: " + chebuRek_sum);

            double ZaikaBabaika_sum = ZaikaBabaika.Sum();
            Console.WriteLine("ZaikaBabaika sum: " + ZaikaBabaika_sum);

            double Bazinga_sum = Bazinga.Sum();
            Console.WriteLine("Bazinga sum: " + Bazinga_sum);

            double dwaHolma_2_sum = dwaHolma_2.Sum();
            Console.WriteLine("dwaHolma_2 sum: " + dwaHolma_2_sum);

            double MohnatieNogi_sum = MohnatieNogi.Sum();
            Console.WriteLine("MohnatieNogi sum: " + MohnatieNogi_sum);

            double GordijElf_sum = GordijElf.Sum();
            Console.WriteLine("GordijElf sum: " + GordijElf_sum);

            double BodriyLiniveZ_sum = BodriyLiniveZ.Sum();
            Console.WriteLine("BodriyLiniveZ sum: " + BodriyLiniveZ_sum);

            double SpontannijTwerk_sum = SpontannijTwerk.Sum();
            Console.WriteLine("SpontannijTwerk sum: " + SpontannijTwerk_sum);

            double UtkonosPoteetMolokom_sum = UtkonosPoteetMolokom.Sum();
            Console.WriteLine("UtkonosPoteetMolokom sum: " + UtkonosPoteetMolokom_sum);

            double Enot_poloskyn_sum = Enot_poloskyn.Sum();
            Console.WriteLine("Enot_poloskyn sum: " + Enot_poloskyn_sum);

            double kuKAreKU_sum = kuKAreKU.Sum();
            Console.WriteLine("kuKAreKU sum: " + kuKAreKU_sum);

            double BoltlivijPon4ik_2_sum = BoltlivijPon4ik_2.Sum();
            Console.WriteLine("BoltlivijPon4ik_2 sum: " + BoltlivijPon4ik_2_sum);


        }
    }
}
