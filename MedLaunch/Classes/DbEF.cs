﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedLaunch.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Migrations;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace MedLaunch.Classes
{
    class DbEF
    {
        public static void InitialSeed()
        {
            // check whether initial seed needs to continue
            bool doSeed = false; 
            using (var db = new MyDbContext())
            {
                var se = db.GlobalSettings.FirstOrDefault();
                if (se == null || se.databaseGenerated == false)
                {
                    doSeed = true;
                }
            }

            if (doSeed == true)
            {


                // Create systems
                List<GameSystem> gSystems = new List<GameSystem>
                {
                    new GameSystem { systemId = 1, systemCode = "gb", systemName = "Nintendo Gameboy/Gameboy Color",
                        systemDescription = "The Game Boy (Japanese: ゲームボーイ Hepburn: Gēmu Bōi?) is an 8-bit handheld video game device developed and manufactured by Nintendo. It was released in Japan on April 21, 1989, in North America on July 31, 1989, and in Europe on September 28, 1990. It is the first handheld console in the Game Boy line, and was created by Gunpei Yokoi and Nintendo Research & Development 1—the same staff who had designed the Game & Watch series as well as several popular games for the Nintendo Entertainment System.[7] Redesigned versions were released in 1996 and 1998, in the form of Game Boy Pocket, and Game Boy Light (Japan only), respectively.\n\nDuring its early lifetime the Game Boy mainly competed with Sega's Game Gear, [[Atari]'s Lynx, and NEC's TurboExpress. The Game Boy beat its rivals and became a tremendous success.[9] The Game Boy and its successor, the Game Boy Color,[6] have both combined sold 118.69 million units worldwide. Upon its release in the United States, it sold its entire shipment of one million units within a few weeks.[10]\n\n\nThe Game Boy Color (ゲームボーイカラー Gēmu Bōi Karā?), referred to as GBC, is a handheld game console manufactured by Nintendo. It was released on October 21, 1998 in Japan[7] and was released in November of the same year in international markets. It is the successor of the Game Boy.\n\nThe Game Boy Color, as suggested by the name, features a color screen, but no backlight. It is slightly thicker and taller than the Game Boy Pocket, which is a redesigned Game Boy released in 1996. As with the original Game Boy, it has a custom 8-bit processor somewhat related to a Zilog Z80 central processing unit (CPU).[8] The original name - with its American English spelling of \"color\" - remained unchanged even in markets where \"colour\" was the accepted English spelling\n\nWhile mostly retaining the same hardware as the original Game Boy, the Game Boy Color's primary competitors were the much more advanced Neo Geo Pocket by SNK and the WonderSwan by Bandai (released in Japan only), though the Game Boy Color outsold these by a huge margin. The Game Boy and Game Boy Color combined have sold 118.69 million units worldwide.[1][2] It was discontinued in 2003, shortly after the release of the Game Boy Advance SP." },
                    new GameSystem { systemId = 2, systemCode = "gba", systemName = "Nintendo Gameboy Advance",
                        systemDescription = "The Game Boy Advance (Japanese: ゲームボーイアドバンス Hepburn: Gēmu Bōi Adobansu?), often shortened to GBA, is a 32-bit handheld video game console developed, manufactured and marketed by Nintendo. It is the successor to the Game Boy Color. It was released in Japan on March 21, 2001; in North America on June 11, 2001; in Australia and Europe on June 22, 2001; and in the People's Republic of China on June 8, 2004 (excluding Hong Kong).\n\nNintendo's competitors in the handheld market were the Neo Geo Pocket Color, WonderSwan, GP32, Tapwave Zodiac, and the N-Gage. Despite the competitors' best efforts, Nintendo maintained a majority market share with the Game Boy Advance.\n\nAs of June 30, 2010, the Game Boy Advance series has sold 81.51 million units worldwide.[8] Its successor, the Nintendo DS, was released in November 2004." },
                    new GameSystem { systemId = 3, systemCode = "lynx", systemName = "Atari Lynx",
                        systemDescription = "The Atari Lynx is an 8-bit handheld game console that was released by Atari Corporation in October 1989 in North America, and in Europe and Japan in 1990. The Lynx holds the distinction of being the world's first handheld electronic game with a color LCD. The system is also notable for its forward-looking features, advanced graphics, and ambidextrous layout. The Lynx competed with the Game Boy (released just 2 months earlier), as well as the Game Gear and TurboExpress, both released the following year.\n\nThe Atari Lynx's innovative features include being the first color handheld, with a backlit display, a switchable right-handed/left-handed (upside down) configuration, and the ability to network with up to 17 other units via its \"Comlynx\" system (though most games would network eight or fewer players). Comlynx was originally developed to run over infrared links (and was codenamed RedEye). This was changed to a cable-based networking system before the final release.\n\nThe Lynx was cited as the \"first gaming console with hardware support for zooming and distortion of sprites\". Featuring a 4096 color palette and integrated math and graphics co-processors (including a blitter unit), its pseudo-3D color graphics display was said to be the key defining feature in the system's competition against Nintendo's monochromatic Game Boy. The fast pseudo-3D graphics features were made possible on a minimal hardware system by codesigner Dave Needle having \"invented the technique for planar expansion/ shrinking capability\" and using stretched, textured, triangles instead of full polygons.[2] These particular features were achieved over a year prior to the launch of the Super NES, whose stock hardware features the comparable Mode 7 but which cannot scale sprites." },
                    new GameSystem { systemId = 4, systemCode = "md", systemName = "Sega Mega Drive/Genesis",
                        systemDescription = "The Sega Genesis, known as the Mega Drive (Japanese: メガドライブ Hepburn: Mega Doraibu?) in most regions outside North America, is a 16-bit home video game console which was developed and sold by Sega Enterprises, Ltd. The Genesis was Sega's third console and the successor to the Master System. Sega first released the console as the Mega Drive in Japan in 1988, followed by a North American debut under the Genesis moniker in 1989. In 1990, the console was distributed as the Mega Drive by Virgin Mastertronic in Europe, by Ozisoft in Australasia, and by Tec Toy in Brazil. In South Korea, the systems were distributed by Samsung and were known as the Super Gam*Boy, and later the Super Aladdin Boy.[b]\n\nDesigned by an R&D team supervised by Hideki Sato and Masami Ishikawa, the hardware was adapted from Sega's System 16 arcade board, centered on a Motorola 68000 processor as a primary CPU and a Zilog Z80 as a secondary processor. The system supports a library of more than 900 games created both by Sega and a wide array of third-party publishers and delivered on ROM-based cartridges. It can play Master System games when the separately sold Power Base Converter is inserted. The Genesis has benefited from several peripherals and network services, as well as multiple first-party and third-party variations of the console that focus on extending its functionality.\n\nSega sold 30.75 million units worldwide. In addition, Tec Toy sold an estimated 3 million licensed variants in Brazil, Majesco projected it would sell 1.5 million licensed variants of the system in the United States, and much smaller numbers were sold by Samsung in South Korea. The console and its games continue to be popular among game fans, game music fans, collectors, and emulation enthusiasts. As of 2015, licensed third party re-releases of the console are being sold by AtGames in North America and Europe. Many games have been re-released in compilations for newer consoles and offered for download on various online services, such as Virtual Console, Xbox Live Arcade, PlayStation Network, and Steam. The Genesis was succeeded by the Sega Saturn." },
                    new GameSystem { systemId = 5, systemCode = "gg", systemName = "Sega Game Gear",
                        systemDescription = "The Game Gear (ゲームギア Gēmu Gia?) is an 8-bit handheld game console released by Sega on October 6, 1990 in Japan, 1991 in North America and Europe, and Australia in 1992. The Game Gear primarily competed with Nintendo's Game Boy, the Atari Lynx and NEC's TurboExpress. The handheld shares much of its hardware with the Master System and is able to play its own titles as well as those of the Master System, the latter being made possible by the use of an adapter. Containing a full-color backlit screen with a landscape format, Sega positioned the Game Gear as a technologically superior handheld to the Game Boy.\n\nThough the Game Gear was rushed to market, its unique game library and price point gave it an edge over the Atari Lynx and TurboExpress. However, due to issues with its short battery life, lack of original titles, and weak support from Sega, the Game Gear was unable to surpass the Game Boy, selling 10.62 million units by March 1996. The Game Gear was succeeded by the Genesis Nomad in 1995 and discontinued in 1997. It was re-released as a budget system by Majesco in 2000, under license by Sega.\n\nReception of the Game Gear was mixed, with praise for its full-color backlit screen and processing power for its time, criticisms over its large size and battery life, and uneven reception over the quality of its game library." },
                    new GameSystem { systemId = 6, systemCode = "ngp", systemName = "NeoGeo Pocket Color",
                        systemDescription = "The Neo Geo Pocket Color (also stylized as NEOGEOPOCKET COLOR, often abbreviated NGPC), is a 16-bit color handheld video game console manufactured by SNK. It is a successor to SNK's monochrome Neo Geo Pocket handheld which debuted in 1998 in Japan, with the Color being fully backwards compatible. The Neo Geo Pocket Color was released on March 16, 1999 in Japan, August 6, 1999 in North America, and on October 1, 1999 in Europe, entering markets all dominated by Nintendo.\n\nAfter a good sales start in both the U.S. and Japan with 14 launch titles (a record at the time)[1] subsequent low retail support in the U.S.,[2] lack of communication with third-party developers by SNK's American management,[3] the craze about Nintendo's Pokémon franchise,[4] anticipation of the 32-bit Game Boy Advance,[4] as well as strong competition from Bandai's WonderSwan in Japan, led to a sales decline in both regions.[5]\n\nDespite its failure the Neo Geo Pocket Color has been regarded as an influential system.[8][9] Many highly acclaimed games were released for the system, such as SNK vs. Capcom: The Match of the Millennium, King of Fighters R-2, and other quality arcade titles derived from SNK's MVS and AES.[4] It also featured an arcade-style microswitched 'clicky stick' joystick, which was praised for its accuracy and being well-suited for fighting games.[4][8][10] The system's display and 40-hour battery life were also well received.[4]" },
                    new GameSystem { systemId = 7, systemCode = "pce", systemName = "PC Engine (CD)/TurboGrafx 16 (CD)/SuperGrafx",
                        systemDescription = "The TurboGrafx-16 Entertainment SuperSystem, known in Japan and in France as the PC Engine (PCエンジン Pī Shī Enjin?), is a home video game console jointly developed by Hudson Soft and NEC Home Electronics, released in Japan on October 30, 1987, in the United States on August 29, 1989, and in France on November 22, 1989. It was the first console released in the 16-bit era, albeit still utilizing an 8-bit CPU. Originally intended to compete with the Nintendo Entertainment System (NES), it ended up competing with the Sega Genesis, and later on the Super NES.\n\n\nThe PC Engine SuperGrafx (PCエンジンスーパーグラフィックス Pī Shī Enjin SūpāGurafikkusu?), also shortened as the SuperGrafx or PC Engine SG, is a video game console by NEC Home Electronics. It is an upgraded version of the PC Engine, released exclusively in Japan.\n\nOriginally announced as the PC Engine 2 (PCエンジン2 Pī Shī Enjin Tsū?), the machine was purported to be a true 16-bit system with improved graphics and audio capabilities over the original PC Engine. Expected to be released in 1990, the SuperGrafx was rushed to market, debuting several months earlier in late 1989 with only modest improvements over the original PC Engine." },
                    new GameSystem { systemId = 8, systemCode = "pcfx", systemName = "PC-FX",
                        systemDescription = "The PC-FX (ピーシー エフエックス Pī Shī Efu Ekkusu?) is a 32-bit home video game console made by NEC Corporation. It was released in Japan on December 23, 1994, just weeks after Sony's PlayStation and a month after the Sega Saturn. It is the successor to NEC's PC Engine, known as TurboGrafx-16 in North America.\n\nUnlike its predecessor, the PC-FX was only released in Japan. The console is shaped just like a tower PC and was meant to be similarly upgradeable. However the PC-FX was using an outdated graphics chip that rendered the system underpowered in comparison to its competitors, which caused it to be a commercial failure. A lack of developer support also meant inadequate games and as a result it was unable to compete effectively with its fifth generation peers. The PC-FX was NEC's last home video game console, and was discontinued in February 1998." },
                    new GameSystem { systemId = 9, systemCode = "psx", systemName = "Sony PlayStation",
                        systemDescription = "The original PlayStation, released on December 3, 1994, was the first of the ubiquitous PlayStation series of console and hand-held game devices. It has included successor consoles and upgrades including the Net Yaroze (a special black PlayStation with tools and instructions to program PlayStation games and applications), \"PSone\" (a smaller version of the original) and the PocketStation (a handheld which enhances PlayStation games and also acts as a memory card). It was part of the fifth generation of video game consoles competing against the Sega Saturn and the Nintendo 64. By December 2003, the PlayStation and PSone had shipped a combined total of 102.49 million units,[22] eventually becoming the first video game console to sell 120 million units.[2]" },
                    new GameSystem { systemId = 10, systemCode = "sms", systemName = "Sega Master System",
                        systemDescription = "The Sega Master System (Japanese: セガマスターシステム Hepburn: Sega Masutā Shisutemu?) is a third-generation home video game console that was manufactured by Sega. It was originally released in 1985 as the Sega Mark III in Japan. After being redesigned prior to its North American launch, the console was renamed Master System and released in 1986 in North America, 1987 in Europe, and 1989 in Brazil. The redesigned Master System was also released in Japan in 1987. Both the Mark III and the original Master System models could play with both cartridges (or \"Mega Cartridges\", as they were officially called) and the credit card-sized Sega Cards, which retailed at lower prices than cartridges but had lower storage capacity; the Master System II and later models did not have the card slot. The Master System also featured accessories such as a light gun and 3D glasses which were designed to work with a range of specially coded games.\n\nSucceeding the SG-1000, the Master System was released as a direct competitor to the Nintendo Entertainment System (NES) in the third generation of video game consoles. The Master System was constructed with hardware superior to that of the NES, but failed to overturn Nintendo's significant market share advantage in Japan and North America. However, it attained significantly more success in Europe and Brazil. The hardware of the Master System also shared many similarities with Sega's handheld game console, the Sega Game Gear. Compared to its competition from Nintendo, the Master System's game library lacks a number of well-received titles due to Nintendo's licensing practices that restricted third-party developers from creating games for any system other than the NES.Sales of the console have been estimated between 10 and 13 million units, not including recent Brazil sales, compared to 62 million NES units sold.Reception to the system given in retrospect gives credit to the system's role in Sega's development of the Sega Genesis, as well as for having a number of well - received titles, particularly in PAL regions, but is generally critical of its small game library.As of 2015, the Master System is the longest - lived game console(30 years and continuing), due to its popularity in Brazil.[11]" },
                    new GameSystem { systemId = 11, systemCode = "nes", systemName = "NES/Famicon",
                        systemDescription = "The Nintendo Entertainment System (commonly abbreviated as NES) is an 8-bit home video game console that was developed and manufactured by Nintendo. It was initially released in Japan as the Family Computer (Japanese: ファミリーコンピュータ Hepburn: Famirī Konpyūta?) (also known by the portmanteau abbreviation Famicom (ファミコン Famikon?) and abbreviated as FC) on July 15, 1983, and was later released in North America during 1985, in Europe during 1986, and Australia in 1987. In South Korea, it was known as the Hyundai Comboy (현대 컴보이 Hyeondae Keomboi) and was distributed by SK Hynix which then was known as Hyundai Electronics. It was succeeded by the Super Nintendo Entertainment System.\n\nThe best-selling gaming console of its time,[10]e[›] the NES helped revitalize the US video game industry following the video game crash of 1983.[11] With the NES, Nintendo introduced a now-standard business model of licensing third-party developers, authorizing them to produce and distribute titles for Nintendo's platform.[12]\n\nIn 2009, the Nintendo Entertainment System was named the single greatest video game console in history by IGN, in a list of 25.[13] It was judged the second greatest console behind the Sega Dreamcast in PC Magazine's \"Top 10 Video Game Consoles of All Time\".[14]" },
                    new GameSystem { systemId = 12, systemCode = "snes", systemName = "SNES/Super Famicom",
                        systemDescription = "The Super Nintendo Entertainment System (officially abbreviated the Super NES[b] or SNES[c], and commonly shortened to Super Nintendo[d]) is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea, 1991 in North America, 1992 in Europe and Australasia (Oceania), and 1993 in South America. In Japan, the system is called the Super Famicom (Japanese: スーパーファミコン Hepburn: Sūpā Famikon?, officially adopting the abbreviated name of its predecessor, the Famicom), or SFC for short. In South Korea, it is known as the Super Comboy (슈퍼 컴보이 Syupeo Keomboi) and was distributed by Hyundai Electronics. Although each version is essentially the same, several forms of regional lockout prevent the different versions from being compatible with one another. It was released in Brazil on September 2, 1992, by Playtronic.\n\nThe SNES is Nintendo's second home console, following the Nintendo Entertainment System (NES). The console introduced advanced graphics and sound capabilities compared with other consoles at the time. The development of a variety of enhancement chips integrated in game cartridges helped to keep it competitive in the marketplace.\n\nThe SNES was a global success, becoming the best-selling console of the 16-bit era despite its relatively late start and the fierce competition it faced in North America and Europe from Sega's Mega Drive/Genesis console. The SNES remained popular well into the 32-bit era, and continues to be popular among fans, collectors, retro gamers, and emulation enthusiasts, some of whom still make homebrew ROM images." },
                    new GameSystem { systemId = 13, systemCode = "ss", systemName = "Sega Saturn",
                        systemDescription = "The Sega Saturn (セガサターン Sega Satān?) is a 32-bit fifth-generation home video game console that was developed by Sega and released on November 22, 1994 in Japan, May 11, 1995 in North America, and July 8, 1995 in Europe as the successor to the successful Sega Genesis. The Saturn has a dual-CPU architecture and eight processors. Its games are in CD-ROM format, and its game library contains several arcade ports as well as original titles.\n\nDevelopment of the Saturn began in 1992, the same year Sega's groundbreaking 3D Model 1 arcade hardware debuted. Designed around a new CPU from Japanese electronics company Hitachi, another video display processor was incorporated into the system's design in early 1994 to better compete with Sony's forthcoming PlayStation. The Saturn was initially successful in Japan, but failed to sell in large numbers in the United States after its surprise May 1995 launch, four months before its scheduled release date. After the debut of the Nintendo 64 in late 1996, the Saturn rapidly lost market share in the U.S., where it was discontinued in 1998. Having sold 9.26 million units worldwide, the Saturn is considered a commercial failure. The failure of Sega's development teams to release a game in the Sonic the Hedgehog series, known in development as Sonic X-treme, has been considered a factor in the console's poor performance.\n\nAlthough the system is remembered for several well-regarded games, including Nights into Dreams..., the Panzer Dragoon series, and the Virtua Fighter series, the Saturn's reputation is mixed due to its complex hardware design and limited third-party support. Sega's management has been criticized for its decision-making during the system's development and discontinuation." },
                    new GameSystem { systemId = 14, systemCode = "vb", systemName = "Nintendo Virtual Boy",
                        systemDescription = "The Virtual Boy (Japanese: バーチャルボーイ Hepburn: Bācharu Bōi?) is a 32-bit table-top 3D video game console developed and manufactured by Nintendo. It was marketed as the first \"portable\" video game console capable of displaying \"true 3D graphics\" out of the box. \n\nIt was released on July 21, 1995, in Japan and August 16, 1995, in North America at a price of US$179.95. It proved to be a commercial failure and was not released in other regions. Its negative reception was unaffected by continued price drops. Nintendo discontinued it on March 2, 1996. The Virtual Boy is Nintendo's second lowest-selling platform after the 64DD." },
                    new GameSystem { systemId = 15, systemCode = "wswan", systemName = "Bandai WonderSwan",
                        systemDescription = "The WonderSwan (ワンダースワン WandāSuwan?) is a handheld game console released in Japan by Bandai. It was developed by Gunpei Yokoi's company Koto Laboratory and Bandai. Released in 1999 in the Fifth generation of video game consoles, the WonderSwan and its two later models, the WonderSwan Color and SwanCrystal were officially supported until being discontinued by Bandai in 2003. During its lifespan, no variation of the WonderSwan was released outside Japan. \n\nPowered by a 16-bit central processing unit, the WonderSwan took advantage of a low price point and long battery life in comparison to its competition, Nintendo's Game Boy Color and SNK's Neo Geo Pocket Color. Later improvements took advantage of quality upgrades to the handheld's screen and added color. The WonderSwan is playable both vertically and horizontally, and features a unique library of games, including numerous first-party titles based on licensed anime properties, as well as significant third-party support from Square, Namco, and Taito. Overall, the WonderSwan in all its variations combined to sell an estimated 3.5 million units and managed to obtain as much as 8% of the Japanese handheld video game console market before being marginalized by Nintendo's Game Boy Advance. Retrospective feedback praises the potential of the WonderSwan despite its low sales and its brief time holding its own against Nintendo in the marketplace." }
                };



                using (var context = new MyDbContext())
                {

                    var gameData = context.GameSystem.AsNoTracking().ToList();
                    foreach (var newEntry in gSystems)
                    {
                        var idLookup = (from e in gameData
                                        where e.systemId == newEntry.systemId
                                        select e).FirstOrDefault();

                        if (idLookup == null)
                        {
                            // entry doesnt exist - insert
                            context.GameSystem.Add(newEntry);
                        }
                        else
                        {
                            // entry exists - update
                            context.GameSystem.Update(newEntry);
                        }
                    }

                    context.SaveChanges();
                }

                // populate Versions table


                // default netplay settings
                ConfigNetplaySettings npSettings = new ConfigNetplaySettings
                {
                    netplay__console__font = "9x18",
                    netplay__console__scale = 1,
                    netplay__console__lines = 5,
                    netplay__localplayers = 1,
                    netplay__nick = "RetroPlayer"
                };
                using (var context = new MyDbContext())
                {
                    context.ConfigNetplaySettings.Add(npSettings);
                    context.SaveChanges();
                }

                // default ConfigBaseSettings population (ConfigID 1 is default for everything)
                ConfigBaseSettings cfbs = new ConfigBaseSettings
                {
                    UpdatedTime = DateTime.Now,
                    autosave = false,
                    cd__image_memcache = false,
                    cheats = true,
                    debugger__autostepmode = false,
                    ffnosound = false,
                    ffspeed = 4,
                    fftoggle = false,

                    filesys__state_comp_level = 6,
                    filesys__untrusted_fip_check = true,
                    input__autofirefreq = 3,
                    input__ckdelay = 0,
                    input__joystick__axis_threshold = 75,
                    input__joystick__global_focus = true,
                    nothrottle = false,
                    osd__alpha_blend = true,
                    osd__message_display_time = 2500,
                    osd__state_display_time = 2000,
                    qtrecord__h_double_threshold = 256,
                    qtrecord__w_double_threshold = 384,
                    qtrecord__vcodec = "cscd",
                    sfspeed = 0.75,
                    sftoggle = false,
                    sound = true,
                    sound__buffer_time = 0,
                    sound__device = "default",
                    sound__driver = "default",
                    sound__period_time = 0,
                    sound__rate = 48000,
                    sound__volume = 100,
                    srwframes = 600,
                    video__blit_timesync = true,
                    video__deinterlacer = "weave",
                    video__disable_composition = true,
                    video__driver = "opengl",
                    video__frameskip = true,
                    video__fs = false,
                    video__glvsync = true
                };
                using (var context = new MyDbContext())
                {
                    context.ConfigBaseSettings.Add(cfbs);
                    context.SaveChanges();
                }


                    // add known servers

                    List<ConfigServerSettings> servers = new List<ConfigServerSettings>
                {
                    new ConfigServerSettings { ConfigServerDesc = "LocalHost (local server required)", netplay__host = "127.0.0.1", netplay__port = 4046,
                        netplay__password = "", netplay__gamekey = "" },
                    new ConfigServerSettings { ConfigServerDesc = "EmuParadise EU Server", netplay__host = "mednafen-nl.emuparadise.org", netplay__port = 4046,
                        netplay__password = "", netplay__gamekey = "" },
                    new ConfigServerSettings { ConfigServerDesc = "EmuParadise US Server", netplay__host = "mednafen-us.emuparadise.org", netplay__port = 4046,
                        netplay__password = "", netplay__gamekey = "" },
                    new ConfigServerSettings { ConfigServerDesc = "Official Mednafen Server", netplay__host = "netplay.fobby.net", netplay__port = 4046,
                        netplay__password = "", netplay__gamekey = "" },
                    new ConfigServerSettings { ConfigServerDesc = "", netplay__host = "", netplay__port = 4046,
                        netplay__password = "", netplay__gamekey = "", ConfigServerId = 100 }
                };
                using (var context = new MyDbContext())
                {
                    context.ConfigServerSettings.AddRange(servers);
                    context.SaveChanges();
                }

                // Create General Settings Entry
                GlobalSettings gs = new GlobalSettings
                {
                    databaseGenerated = false,
                    fullGuiScreen = false,
                    fullScreen = true,
                    bypassConfig = false,
                    settingsId = 1,
                    enableNetplay = true,
                    serverSelected = 1
                };
                using (var context = new MyDbContext())
                {
                    context.GlobalSettings.Add(gs);
                    context.SaveChanges();
                }

                // create Paths entry
                Paths paths = new Paths
                {
                    pathId = 1
                };
                using (var context = new MyDbContext())
                {
                    context.Paths.Add(paths);
                    context.SaveChanges();
                }


                //add test rom data
                /*
                List<Game> roms = new List<Game>
                {
                  new Game { gameName = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 8), gamePath = ".\\", systemId = 3, hidden = false, isFavorite = true },
                  new Game { gameName = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 8), gamePath = ".\\", systemId = 10, hidden = false, isFavorite = false }
                };
                using (var context = new MyDbContext())
                {

                    context.Game.AddRange(roms);
                    context.SaveChanges();
                }
                */

                // initial seeding complete. mark GeneralSettings table so that regeneration does not occur
                GlobalSettings set;
                using (var context = new MyDbContext())
                {
                    set = (from a in context.GlobalSettings
                           where a.settingsId == 1
                           select a).FirstOrDefault<GlobalSettings>();
                }

                if (set != null)
                {
                    set.databaseGenerated = true;
                }

                using (var dbCtx = new MyDbContext())
                {
                    dbCtx.Entry(set).State = EntityState.Modified;
                    dbCtx.SaveChanges();
                }
            }
        }

        // 'games' page global settings

        // return Global Settings entry from DB
        private static GlobalSettings GetGlobals()
        {
            GlobalSettings gs = new GlobalSettings();
            using (var context = new MyDbContext())
            {
                var query = from s in context.GlobalSettings
                            where s.settingsId == 1
                            select s;
                gs = query.FirstOrDefault();
            }
            return gs;
        }

        // write Global Settings object to DB
        private static void SetGlobals(GlobalSettings gs)
        {
            using (var context = new MyDbContext())
            {
                context.GlobalSettings.Attach(gs);
                var entry = context.Entry(gs);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void LoadGlobalSettings(CheckBox EnableNetplay, CheckBox FullScreen, CheckBox BypassConfig)
        {
            GlobalSettings gs = GetGlobals();
            // update all checkboxes
            EnableNetplay.IsChecked = gs.enableNetplay;
            FullScreen.IsChecked = gs.fullScreen;
            BypassConfig.IsChecked = gs.bypassConfig;
        }

        public static void UpdateEnableNetplay (CheckBox EnableNetplay)
        {
            GlobalSettings gs = GetGlobals();
            gs.enableNetplay = EnableNetplay.IsChecked;
            SetGlobals(gs);

        }
        public static void UpdateFullScreen(CheckBox FullScreen)
        {
            GlobalSettings gs = GetGlobals();
            gs.fullScreen = FullScreen.IsChecked;
            SetGlobals(gs);
        }
        public static void UpdateBypassConfig(CheckBox BypassConfig)
        {
            GlobalSettings gs = GetGlobals();
            gs.bypassConfig = BypassConfig.IsChecked;
            SetGlobals(gs);
        }



        // netplay settings

        // return Netplay Settings entry from DB
        private static ConfigNetplaySettings GetNetplay()
        {
            ConfigNetplaySettings nps = new ConfigNetplaySettings();
            using (var context = new MyDbContext())
            {
                var query = from s in context.ConfigNetplaySettings
                            where s.ConfigNPId == 1
                            select s;
                nps = query.FirstOrDefault();
            }
            return nps;
        }

        // write Global Settings object to DB
        private static void SetNetplay(ConfigNetplaySettings nps)
        {
            using (var context = new MyDbContext())
            {
                context.ConfigNetplaySettings.Attach(nps);
                var entry = context.Entry(nps);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static void LoadNetplaySettings(TextBox Nickname, Slider LocalPlayers, Slider ConsoleLines, Slider ConsoleScale, 
            RadioButton resOne, RadioButton resTwo, RadioButton resThree, RadioButton resFour, RadioButton resFive)
        {
            ConfigNetplaySettings nps = GetNetplay();

            Nickname.Text = nps.netplay__nick;
            LocalPlayers.Value = Convert.ToDouble(nps.netplay__localplayers);
            ConsoleLines.Value = Convert.ToDouble(nps.netplay__console__lines);
            ConsoleScale.Value = Convert.ToDouble(nps.netplay__console__scale);

            if (nps.netplay__console__font == "5x7")
                resOne.IsChecked = true;
            if (nps.netplay__console__font == "6x9")
                resTwo.IsChecked = true;
            if (nps.netplay__console__font == "6x12")
                resThree.IsChecked = true;
            if (nps.netplay__console__font == "6x13")
                resFour.IsChecked = true;
            if (nps.netplay__console__font == "9x18")
                resFive.IsChecked = true;
        }

        public static void SaveNetplaySettings(TextBox Nickname, Slider LocalPlayers, Slider ConsoleLines, Slider ConsoleScale,
            RadioButton resOne, RadioButton resTwo, RadioButton resThree, RadioButton resFour, RadioButton resFive)
        {
            ConfigNetplaySettings nps = GetNetplay();
            nps.netplay__nick = Nickname.Text;
            nps.netplay__localplayers = Convert.ToInt32(LocalPlayers.Value);
            nps.netplay__console__lines = Convert.ToInt32(ConsoleLines.Value);
            nps.netplay__console__scale = Convert.ToInt32(ConsoleScale.Value);

            if (resOne.IsChecked == true)
                nps.netplay__console__font = "5x7";
            if (resTwo.IsChecked == true)
                nps.netplay__console__font = "6x9";
            if (resThree.IsChecked == true)
                nps.netplay__console__font = "6x12";
            if (resFour.IsChecked == true)
                nps.netplay__console__font = "6x13";
            if (resFive.IsChecked == true)
                nps.netplay__console__font = "9x18";

            SetNetplay(nps);
        }


        // Server Settings

        // return all servers from database
        public static List<ConfigServerSettings> GetServers()
        {
            List<ConfigServerSettings> servers = new List<ConfigServerSettings>();
            using (var srvContext = new MyDbContext())
            {
                var allSrvs = from s in srvContext.ConfigServerSettings
                              select s;
                servers.AddRange(allSrvs);
            }
            return servers;
        }

        // pouplate servers combobox
        public static void PopulateServersCombo(ComboBox cb)
        {
            // get all servers
            List<ConfigServerSettings> servers = GetServers();

            cb.ItemsSource = typeof(Colors).GetProperties();
        }

        // pouplate servers datagrid
        public static void PopulateServersDatagrid(DataGrid cb)
        {
            List<DataGridServersView> srvs = new List<DataGridServersView>();
            var servers = GetServers();
            
            // iterate through each server entry returned from the database
            foreach (var s in servers)
            {
                DataGridServersView server = new DataGridServersView();
                server.ID = s.ConfigServerId;
                server.Description = s.ConfigServerDesc;
                server.Gamekey = s.netplay__gamekey;
                server.Hostname = s.netplay__host;
                server.Password = s.netplay__password;
                server.Port = s.netplay__port.Value;

                srvs.Add(server);
            }

            cb.ItemsSource = srvs;
            
        }
        // server radio box - get id
        public static int GetServerRadioId(string rbName)
        {
            int sid = 1;
            switch (rbName)
            {                
                case "rbSrv01":
                    // ID1
                    sid = 1;
                    break;
                case "rbSrv02":
                    // ID2
                    sid = 2;
                    break;
                case "rbSrv03":
                    // ID3
                    sid = 3;
                    break;
                case "rbSrv04":
                    // ID4
                    sid = 4;
                    break;
                case "rbSrvCustom":
                    // User Custom
                    sid = 100;
                    break;
                default:
                    sid = 1;
                    break;
            }
            return sid;
        }

        

        // populate servers radio
        public static void PopulateServersRadio(RadioButton rb)
        {
            var servers = GetServers();
            string rbName = rb.Name;
            //int sid = 1;
            int sid = GetServerRadioId(rbName);
            

            var server = (from s in servers
                          where s.ConfigServerId == sid
                          select s).SingleOrDefault();

            if (server.ConfigServerId == 100)
            {
                // this is the custom server
            }
            else
            {
                string strBuild = server.ConfigServerDesc + " \n(" + server.netplay__host + ":" + server.netplay__port + " )";
                rb.Content = strBuild;
            }            
        }

        public static void PopulateCustomServer(TextBox tbServerDesc, TextBox tbHostname, Slider slServerPort, TextBox tbPassword, TextBox tbGamekey)
        {
            var servers = GetServers();
            var server = (from s in servers
                         where s.ConfigServerId == 100
                         select s).SingleOrDefault();

            tbServerDesc.Text = server.ConfigServerDesc;
            tbHostname.Text = server.netplay__host;
            slServerPort.Value = Convert.ToDouble(server.netplay__port);
            tbPassword.Text = server.netplay__password;
            tbGamekey.Text = server.netplay__gamekey;
        }

        public static void SetSelectedServer(RadioButton rb)
        {
            GlobalSettings gs = GetGlobals();
            int sid = GetServerRadioId(rb.Name);

            gs.serverSelected = sid;
            SetGlobals(gs);
        }

        public static void GetSelectedServerCheckbox(RadioButton rbSrv01, RadioButton rbSrv02, RadioButton rbSrv03, RadioButton rbSrv04, RadioButton rbSrvCustom)
        {
            GlobalSettings gs = GetGlobals();
            int id = gs.serverSelected.Value;

            // wipe values
            rbSrv01.IsChecked = true;
            rbSrv02.IsChecked = true;
            rbSrv03.IsChecked = true;
            rbSrv04.IsChecked = true;
            rbSrvCustom.IsChecked = true;
            rbSrv01.IsChecked = true;

            switch (id)
            {
                case 1:
                    rbSrv01.IsChecked = true;
                    break;
                case 2:
                    rbSrv02.IsChecked = true;
                    break;
                case 3:
                    rbSrv03.IsChecked = true;
                    break;
                case 4:
                    rbSrv04.IsChecked = true;
                    break;
                case 100:
                    rbSrvCustom.IsChecked = true;
                    break;
                default:
                    rbSrv01.IsChecked = true;
                    break;                        
            }
        }

        public static void SaveCustomServerSettings(TextBox tbServerDesc, TextBox tbHostname, Slider slServerPort, TextBox tbPassword, TextBox tbGameKey)
        {
            ConfigServerSettings sSet = new ConfigServerSettings();
            var servers = GetServers();
            sSet = (from s in servers
                          where s.ConfigServerId == 100
                          select s).SingleOrDefault();

            sSet.ConfigServerId = 100;
            sSet.ConfigServerDesc = tbServerDesc.Text;
            sSet.netplay__host = tbHostname.Text;
            sSet.netplay__password = tbPassword.Text;
            sSet.netplay__gamekey = tbGameKey.Text;
            sSet.netplay__port = Convert.ToInt32(slServerPort.Value);

            SetCustomServer(sSet);
        }
        private static void SetCustomServer(ConfigServerSettings srv)
        {
            using (var context = new MyDbContext())
            {
                context.ConfigServerSettings.Attach(srv);
                var entry = context.Entry(srv);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }







        // Paths

        // return Paths entry from DB
        private static Paths GetPaths()
        {
            Paths paths = new Paths();
            using (var context = new MyDbContext())
            {
                var query = from s in context.Paths
                            where s.pathId == 1
                            select s;
                paths = query.FirstOrDefault();
            }
            return paths;
        }

        // write paths object to DB
        private static void SetPaths(Paths paths)
        {
            using (var context = new MyDbContext())
            {
                context.Paths.Attach(paths);
                var entry = context.Entry(paths);
                entry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Populate path forms with DB data
        public static void LoadPathSettings(TextBox tbPathMednafen, TextBox tbPathGb, TextBox tbPathGba, TextBox tbPathGg, TextBox tbPathLynx, TextBox tbPathMd,
            TextBox tbPathNes, TextBox tbPathSnes, TextBox tbPathNgp, TextBox tbPathPce, TextBox tbPathPcfx, TextBox tbPathMs,
            TextBox tbPathVb, TextBox tbPathWswan) // TextBox tbPathPsx, TextBox tbPathSs)
        {
            Paths paths = GetPaths();

            tbPathMednafen.Text = paths.mednafenExe;
            tbPathGb.Text = paths.systemGb;
            tbPathGba.Text = paths.systemGba;
            tbPathGg.Text = paths.systemGg;
            tbPathLynx.Text = paths.systemLynx;
            tbPathMd.Text = paths.systemMd;
            tbPathMs.Text = paths.systemSms;
            tbPathNes.Text = paths.systemNes;
            tbPathNgp.Text = paths.systemNgp;
            tbPathPce.Text = paths.systemPce;
            tbPathPcfx.Text = paths.systemPcfx;
            //tbPathPsx.Text = paths.systemPsx;
            tbPathSnes.Text = paths.systemSnes;
            //tbPathSs.Text = paths.systemSs;
            tbPathVb.Text = paths.systemVb;
            tbPathWswan.Text = paths.systemWswan;
        }

        // save path settings from form
        public static void SavePathSettings(TextBox tbPathMednafen, TextBox tbPathGb, TextBox tbPathGba, TextBox tbPathGg, TextBox tbPathLynx, TextBox tbPathMd,
            TextBox tbPathNes, TextBox tbPathSnes, TextBox tbPathNgp, TextBox tbPathPce, TextBox tbPathPcfx,  TextBox tbPathMs,
            TextBox tbPathVb, TextBox tbPathWswan) // TextBox tbPathPsx, TextBox tbPathSs)
        {
            Paths paths = GetPaths();
            paths.mednafenExe = tbPathMednafen.Text;
            paths.systemGb = tbPathGb.Text;
            paths.systemGba = tbPathGba.Text;
            paths.systemGg = tbPathGg.Text;
            paths.systemLynx = tbPathLynx.Text;
            paths.systemMd = tbPathMd.Text;
            paths.systemSms = tbPathMs.Text;
            paths.systemNes = tbPathNes.Text;
            paths.systemNgp = tbPathNgp.Text;
            paths.systemPce = tbPathPce.Text;
            paths.systemPcfx = tbPathPcfx.Text;
            //paths.systemPsx = tbPathPsx.Text;
            paths.systemSnes = tbPathSnes.Text;
            //paths.systemSs = tbPathSs.Text;
            paths.systemVb = tbPathVb.Text;
            paths.systemWswan = tbPathWswan.Text;

            SetPaths(paths);
        }


        public static List<GameListView> FetchGames()
        {
            List<GameListView> initialList = new List<GameListView>();

            using (var context = new MyDbContext())
            {
                //var gameList = context.Game.AsNoTracking().ToList();
                var gameList = from p in context.Game
                               where p.gameId > 0 && p.GameSystem.systemId == p.systemId
                               select new { p.gameId, p.gameName, p.gameLastPlayed, p.gamePath, p.systemId, p.GameSystem.systemName, p.GameSystem.systemDescription };

                foreach (var g in gameList)
                {
                    GameListView gameRecord = new GameListView();

                    gameRecord.GameId = g.gameId;
                    gameRecord.GameLastPlayed = g.gameLastPlayed;
                    gameRecord.GameName = g.gameName;
                    gameRecord.GamePath = g.gamePath;
                    gameRecord.SystemName = g.systemName;
                    gameRecord.SystemDescription = g.systemDescription;
                    gameRecord.SystemId = g.systemId;

                    initialList.Add(gameRecord);
                }
            }

            return initialList;

        }

        // return game data for games datagrid
        public static List<DataGridGamesView> GetGames(int systemId)
        {
            List<DataGridGamesView> gms = new List<DataGridGamesView>();
            using (var context = new MyDbContext())
            {
                if (systemId < 1)
                {
                    // show all games
                    var query = from g in context.Game
                                orderby g.gameName
                                select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                    foreach (var g in query)
                    {
                        DataGridGamesView dgGamesList = new DataGridGamesView();
                        dgGamesList.ID = g.gameId;
                        dgGamesList.Game = g.gameName;
                        dgGamesList.System = g.systemName;
                        dgGamesList.Favorite = g.isFavorite;
                        string lp;
                        if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                        {
                            lp = "NEVER";
                        }
                        else
                        {
                            lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        dgGamesList.LastPlayed = lp;

                        gms.Add(dgGamesList);
                    }
                }
                else
                {
                    // filter based on systemId
                    var query = from g in context.Game
                                where g.systemId == systemId
                                orderby g.gameName
                                select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                    foreach (var g in query)
                    {
                        DataGridGamesView dgGamesList = new DataGridGamesView();
                        dgGamesList.ID = g.gameId;
                        dgGamesList.Game = g.gameName;
                        dgGamesList.System = g.systemName;
                        dgGamesList.Favorite = g.isFavorite;
                        string lp;
                        if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                        {
                            lp = "NEVER";
                        }
                        else
                        {
                            lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        dgGamesList.LastPlayed = lp;

                        gms.Add(dgGamesList);
                    }
                }

            }

            return gms;
            //datagrid.ItemsSource = gms;

        }

        // update game data for games datagrid
        public static void GetGames(DataGrid datagrid, int systemId)
        {
            List<DataGridGamesView> gms = new List<DataGridGamesView>();
            using (var context = new MyDbContext())
            {
                if (systemId < 1)
                {
                    // show all games
                    var query = from g in context.Game
                                orderby g.gameName
                                select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                    foreach (var g in query)
                    {
                        DataGridGamesView dgGamesList = new DataGridGamesView();
                        dgGamesList.ID = g.gameId;
                        dgGamesList.Game = g.gameName;
                        dgGamesList.System = g.systemName;
                        dgGamesList.Favorite = g.isFavorite;
                        string lp;
                        if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                        {
                            lp = "NEVER";
                        }
                        else
                        {
                            lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        dgGamesList.LastPlayed = lp;

                        gms.Add(dgGamesList);
                    }
                }
                else
                {
                    // filter based on systemId
                    var query = from g in context.Game
                                where g.systemId == systemId
                                orderby g.gameName
                                select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                    foreach (var g in query)
                    {
                        DataGridGamesView dgGamesList = new DataGridGamesView();
                        dgGamesList.ID = g.gameId;
                        dgGamesList.Game = g.gameName;
                        dgGamesList.System = g.systemName;
                        dgGamesList.Favorite = g.isFavorite;
                        string lp;
                        if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                        {
                            lp = "NEVER";
                        }
                        else
                        {
                            lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        dgGamesList.LastPlayed = lp;

                        gms.Add(dgGamesList);
                    }
                }
                
            }

            //return gms;
            datagrid.ItemsSource = gms;
            
        }
        // update game data for games datagrid including search
        public static void GetGames(DataGrid datagrid, int systemId, string search)
        {
            List<DataGridGamesView> gms = new List<DataGridGamesView>();
            using (var context = new MyDbContext())
            {
                // favorites display
                if (systemId == -1)
                {
                    // show all games
                    var favQuery = from g in context.Game
                                   where (g.gameName.Contains(search) || g.GameSystem.systemName.Contains(search)) && g.isFavorite == true
                                   orderby g.gameName
                                   select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                    foreach (var g in favQuery)
                    {
                        DataGridGamesView dgGamesList = new DataGridGamesView();
                        dgGamesList.ID = g.gameId;
                        dgGamesList.Game = g.gameName;
                        dgGamesList.System = g.systemName;
                        dgGamesList.Favorite = g.isFavorite;
                        string lp;
                        if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                        {
                            lp = "NEVER";
                        }
                        else
                        {
                            lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        dgGamesList.LastPlayed = lp;

                        gms.Add(dgGamesList);
                    }
                }
                else
                {
                    if (systemId == 0)
                    {
                        // show all games
                        var query = from g in context.Game
                                    where g.gameName.Contains(search) || g.GameSystem.systemName.Contains(search)
                                    orderby g.gameName
                                    select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                        foreach (var g in query)
                        {
                            DataGridGamesView dgGamesList = new DataGridGamesView();
                            dgGamesList.ID = g.gameId;
                            dgGamesList.Game = g.gameName;
                            dgGamesList.System = g.systemName;
                            dgGamesList.Favorite = g.isFavorite;
                            string lp;
                            if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                            {
                                lp = "NEVER";
                            }
                            else
                            {
                                lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            dgGamesList.LastPlayed = lp;

                            gms.Add(dgGamesList);
                        }
                    }
                    else
                    {
                        // filter based on systemId
                        var query = from g in context.Game
                                    where g.systemId == systemId && (g.gameName.Contains(search) || g.GameSystem.systemName.Contains(search))
                                    orderby g.gameName
                                    select new { g.gameId, g.gameName, g.GameSystem.systemName, g.gameLastPlayed, g.isFavorite };
                        foreach (var g in query)
                        {
                            DataGridGamesView dgGamesList = new DataGridGamesView();
                            dgGamesList.ID = g.gameId;
                            dgGamesList.Game = g.gameName;
                            dgGamesList.System = g.systemName;
                            dgGamesList.Favorite = g.isFavorite;
                            string lp;
                            if (g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss") == "0001-01-01 00:00:00")
                            {
                                lp = "NEVER";
                            }
                            else
                            {
                                lp = g.gameLastPlayed.ToString("yyyy-MM-dd HH:mm:ss");
                            }
                            dgGamesList.LastPlayed = lp;

                            gms.Add(dgGamesList);
                        }
                    }
                }

                

            }

            //return gms;
            datagrid.ItemsSource = gms;

        }

        public static void GetInfo(int gameID, Label sysLabel, TextBlock sysDesc, Image sysImage)//, Image gameImage)
        {
            // gets game and system info from the database and populates the right information panel

            // get system info first
            using (var context = new MyDbContext())
            {
                var gameInfo = (from g in context.Game
                               where g.gameId == gameID
                               select g).FirstOrDefault();

                var sysInfo = (from s in context.GameSystem
                               where s.systemId == gameInfo.systemId
                               select new { s.systemName, s.systemDescription, s.systemId }).FirstOrDefault();

                // image handling
                string image = @"Graphics\Icons\na.png";
                if (sysInfo != null)
                { 
                    if (sysInfo.systemId == 10)
                    {
                        // master system
                        image = @"Graphics\Systems\snes.jpg";
                    }
                    else
                    {
                        image = @"Graphics\Icons\na.png";
                    }

                }

                // set system image
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri(image, UriKind.Relative);
                b.EndInit();

                // ... Get Image reference from sender.
                //var image = sender as Image;
                // ... Assign Source.
                sysImage.Source = b;
                //sysImage.Source = new BitmapImage(new Uri(image, UriKind.Relative));

                // set system label
                sysLabel.Content = sysInfo.systemName;

                // set system description
                sysDesc.Text = sysInfo.systemDescription;
                
            }
        }

        
    }
}
