using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.GUI
{
    public static class DefaultPatterns
    {
        public static readonly string GliderPattern =   "-X-\n" +
                                                        "--X\n" +
                                                        "XXX";

        public static readonly string RowPattern = "XXXXXXXX-XXXXX---XXX------XXXXXXX-XXXXX";

        public static readonly string SpaceshipPattern =    "--XX-\n" +
                                                            "-XXXX\n" +
                                                            "XX-XX\n" +
                                                            "-XX--";

        public static readonly string GliderGunPattern =    "-------------------------X----------\n" +
                                                            "----------------------XXXX----X-----\n" +
                                                            "-------------X-------XXXX-----X-----\n" +
                                                            "------------X-X------X--X---------XX\n" +
                                                            "-----------X---XX----XXXX---------XX\n" +
                                                            "XX---------X---XX-----XXXX----------\n" +
                                                            "XX---------X---XX--------X----------\n" +
                                                            "------------X-X---------------------\n" +
                                                            "-------------X----------------------";

        public static readonly string Period15Pattern = "--X----X--\n" +
                                                        "XX-XXXX-XX\n" +
                                                        "--X----X--";

        public static readonly string PulsarPattern =   "--XXX---XXX--\n" +
                                                         "-------------\n" +
                                                         "X----X-X----X\n" +
                                                         "X----X-X----X\n" +
                                                         "X----X-X----X\n" +
                                                         "--XXX---XXX--\n" +
                                                         "-------------\n" +
                                                         "--XXX---XXX--\n" +
                                                         "X----X-X----X\n" +
                                                         "X----X-X----X\n" +
                                                         "X----X-X----X\n" +
                                                         "-------------\n" +
                                                         "--XXX---XXX--\n";
    }
}
