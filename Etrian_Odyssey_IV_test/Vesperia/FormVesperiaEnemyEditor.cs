using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Etrian_Odyssey_IV_test
{
    public partial class FormVesperiaEnemyEditor : Form
    {
        
        byte[] enemydata_array; //This starts the array, the name after is what i name this array?

        public FormVesperiaEnemyEditor()
        {
            InitializeComponent();

            string enemydata_path = Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"; //This defines the path as a string, so i can refer to it by this string/name instead of the full path every time
            int enemydata_length = (int)(new FileInfo(enemydata_path).Length);   //The leagth of the array?
            enemydata_array = File.ReadAllBytes(enemydata_path);  //loads an array with whatever is in the path

            //Add the EO1 enemy list to the in editor list of enemy names
            enemyTree.Nodes.Add("0 Knight Fencer");
            enemyTree.Nodes.Add("1 Knight Guard");
            enemyTree.Nodes.Add("2 Knight Warrior");
            enemyTree.Nodes.Add("HIDDEN Knight Fencer H");
            enemyTree.Nodes.Add("3 Knight Fencer A");
            enemyTree.Nodes.Add("4 Knight Fencer F");
            enemyTree.Nodes.Add("5 Knight Fencer K");
            enemyTree.Nodes.Add("6 Knight Fencer S");
            enemyTree.Nodes.Add("HIDDEN Knight Warrior H");
            enemyTree.Nodes.Add("7 Knight Warrior A");
            enemyTree.Nodes.Add("HIDDEN Knight Warrior F");
            enemyTree.Nodes.Add("HIDDEN Knight Warrior K");
            enemyTree.Nodes.Add("HIDDEN Knight Warrior S");
            enemyTree.Nodes.Add("8 Grain");
            enemyTree.Nodes.Add("9 Knight Lancer");
            enemyTree.Nodes.Add("10 Knight Catcher");
            enemyTree.Nodes.Add("11 Knight Halberd");
            enemyTree.Nodes.Add("12 Knight Halberd A");
            enemyTree.Nodes.Add("13 Knight Halberd F");
            enemyTree.Nodes.Add("HIDDEN Knight Halberd K");
            enemyTree.Nodes.Add("HIDDEN Knight Halberd S");
            enemyTree.Nodes.Add("14 Erungar");
            enemyTree.Nodes.Add("15 Erungar (Team Battle)");
            enemyTree.Nodes.Add("16 Erungar Memory");
            enemyTree.Nodes.Add("HIDDEN Knight Lancer H");
            enemyTree.Nodes.Add("17 Knight Lancer A");
            enemyTree.Nodes.Add("HIDDEN Knight Lancer F");
            enemyTree.Nodes.Add("18 Knight Lancer K");
            enemyTree.Nodes.Add("19 Knight Lancer S");
            enemyTree.Nodes.Add("20 Augusto");
            enemyTree.Nodes.Add("21 Rye");
            enemyTree.Nodes.Add("22 Bandido");
            enemyTree.Nodes.Add("23 Bandido");
            enemyTree.Nodes.Add("24 Bandido Memory");
            enemyTree.Nodes.Add("25 Jugem");
            enemyTree.Nodes.Add("26 Jugem (Team Battle)");
            enemyTree.Nodes.Add("27 Jugem Memory");
            enemyTree.Nodes.Add("28 Rogue");
            enemyTree.Nodes.Add("29 Thief");
            enemyTree.Nodes.Add("30 Sand Thief");
            enemyTree.Nodes.Add("31 Jun");
            enemyTree.Nodes.Add("32 Bre");
            enemyTree.Nodes.Add("33 Soya");
            enemyTree.Nodes.Add("34 Pepe");
            enemyTree.Nodes.Add("35 Seigle");
            enemyTree.Nodes.Add("36 Soldier");
            enemyTree.Nodes.Add("37 Soldier");
            enemyTree.Nodes.Add("38 Johann");
            enemyTree.Nodes.Add("39 Johann (Team Battle)");
            enemyTree.Nodes.Add("40 Johann Memory");
            enemyTree.Nodes.Add("41 Warrior");
            enemyTree.Nodes.Add("42 Burglar");
            enemyTree.Nodes.Add("43 Savage Helm");
            enemyTree.Nodes.Add("44 October");
            enemyTree.Nodes.Add("45 Orge");
            enemyTree.Nodes.Add("46 Maize");
            enemyTree.Nodes.Add("47 Gingembre");
            enemyTree.Nodes.Add("48 Barley");
            enemyTree.Nodes.Add("49 Lett");
            enemyTree.Nodes.Add("50 Bronze");
            enemyTree.Nodes.Add("51 Titane");
            enemyTree.Nodes.Add("52 Plomb");
            enemyTree.Nodes.Add("53 Cuivre");
            enemyTree.Nodes.Add("54 Zinc");
            enemyTree.Nodes.Add("55 Etain");
            enemyTree.Nodes.Add("56 Fer");
            enemyTree.Nodes.Add("57 Argent");
            enemyTree.Nodes.Add("58 Knight Bishop");
            enemyTree.Nodes.Add("59 High Knight Bishop");
            enemyTree.Nodes.Add("60 Witch");
            enemyTree.Nodes.Add("61 Witch Memory");
            enemyTree.Nodes.Add("62 Sorceress");
            enemyTree.Nodes.Add("63 Druid");
            enemyTree.Nodes.Add("64 July");
            enemyTree.Nodes.Add("65 Ail");
            enemyTree.Nodes.Add("66 Piment");
            enemyTree.Nodes.Add("67 Susa");
            enemyTree.Nodes.Add("68 Val");
            enemyTree.Nodes.Add("69 Gilga");
            enemyTree.Nodes.Add("70 Filifolia");
            enemyTree.Nodes.Add("71 Filifolia Bud                     Test Dummy 1");
            enemyTree.Nodes.Add("72 Filifolia Puff");
            enemyTree.Nodes.Add("HIDDEN Filifolia Mutant");
            enemyTree.Nodes.Add("73 Filihelia");
            enemyTree.Nodes.Add("74 Wilted Filifolia");
            enemyTree.Nodes.Add("75 Fly Roper J");
            enemyTree.Nodes.Add("76 Bantam Roper J");
            enemyTree.Nodes.Add("77 Light Roper J");
            enemyTree.Nodes.Add("78 Welter Roper J");
            enemyTree.Nodes.Add("79 Middle Roper J");
            enemyTree.Nodes.Add("80 Heavy Roper J");
            enemyTree.Nodes.Add("81 Treant");
            enemyTree.Nodes.Add("82 Blooms");
            enemyTree.Nodes.Add("83 Paincorn");
            enemyTree.Nodes.Add("84 Limewreath");
            enemyTree.Nodes.Add("85 Deadwreath");
            enemyTree.Nodes.Add("86 Insect Plant");
            enemyTree.Nodes.Add("87 Trifid");
            enemyTree.Nodes.Add("88 Audreitz");
            enemyTree.Nodes.Add("89 Fly Roper");
            enemyTree.Nodes.Add("90 Bantam Roper");
            enemyTree.Nodes.Add("91 Light Roper");
            enemyTree.Nodes.Add("92 Welter Roper");
            enemyTree.Nodes.Add("93 Middle Roper");
            enemyTree.Nodes.Add("94 Heavy Roper");
            enemyTree.Nodes.Add("95 Jons");
            enemyTree.Nodes.Add("96 Aquicia");
            enemyTree.Nodes.Add("97 Roctus");
            enemyTree.Nodes.Add("98 Cactus");
            enemyTree.Nodes.Add("99 Tuliper");
            enemyTree.Nodes.Add("100 Rosa Camellia");
            enemyTree.Nodes.Add("101 Hawk");
            enemyTree.Nodes.Add("102 Horse Raptor");
            enemyTree.Nodes.Add("103 Rabtor");
            enemyTree.Nodes.Add("104 Eon Raptor");
            enemyTree.Nodes.Add("105 Firebird");
            enemyTree.Nodes.Add("106 Flame Bird");
            enemyTree.Nodes.Add("107 Penguinist");
            enemyTree.Nodes.Add("108 Private Bat");
            enemyTree.Nodes.Add("109 Chief Bat");
            enemyTree.Nodes.Add("110 Captain Bat");
            enemyTree.Nodes.Add("111 Major Bat");
            enemyTree.Nodes.Add("112 Colonel Bat");
            enemyTree.Nodes.Add("113 General Bat");
            enemyTree.Nodes.Add("114 Chirpee");
            enemyTree.Nodes.Add("HIDDEN Chirpee");
            enemyTree.Nodes.Add("115 Bat");
            enemyTree.Nodes.Add("116 Black Bat");
            enemyTree.Nodes.Add("117 Howler");
            enemyTree.Nodes.Add("118 Red-eyed Bat");
            enemyTree.Nodes.Add("119 Scissorbeak");
            enemyTree.Nodes.Add("120 Drillbeak");
            enemyTree.Nodes.Add("121 Firebat");
            enemyTree.Nodes.Add("122 Flame Bat");
            enemyTree.Nodes.Add("123 Thunder Bat");
            enemyTree.Nodes.Add("124 Clappit");
            enemyTree.Nodes.Add("125 Popper");
            enemyTree.Nodes.Add("126 Honker");
            enemyTree.Nodes.Add("127 Hammerbeak");
            enemyTree.Nodes.Add("128 Leaf Bat");
            enemyTree.Nodes.Add("129 Ice Bat");
            enemyTree.Nodes.Add("130 Private Bat J");
            enemyTree.Nodes.Add("131 Chief Bat J");
            enemyTree.Nodes.Add("132 Captain Bat J");
            enemyTree.Nodes.Add("133 Major Bat J");
            enemyTree.Nodes.Add("134 Colonel Bat J");
            enemyTree.Nodes.Add("135 General Bat J");
            enemyTree.Nodes.Add("136 Tortoise");
            enemyTree.Nodes.Add("137 Roctoise");
            enemyTree.Nodes.Add("138 Cannosso");
            enemyTree.Nodes.Add("139 Crystea");
            enemyTree.Nodes.Add("140 Erdas");
            enemyTree.Nodes.Add("141 Crab Man");
            enemyTree.Nodes.Add("142 Aquates Assassin");
            enemyTree.Nodes.Add("143 Spider");
            enemyTree.Nodes.Add("144 Green Spider");
            enemyTree.Nodes.Add("145 Sworpion");
            enemyTree.Nodes.Add("146 Deathseeker");
            enemyTree.Nodes.Add("147 Watergunner");
            enemyTree.Nodes.Add("148 Crab Lieutenant");
            enemyTree.Nodes.Add("149 Crab Captain");
            enemyTree.Nodes.Add("150 Crab Admiral");
            enemyTree.Nodes.Add("151 Ribbit");
            enemyTree.Nodes.Add("152 Clukkit");
            enemyTree.Nodes.Add("153 Spikkit");
            enemyTree.Nodes.Add("154 Gobley");
            enemyTree.Nodes.Add("155 Venomey");
            enemyTree.Nodes.Add("156 Rasslebit");
            enemyTree.Nodes.Add("157 Pearllit");
            enemyTree.Nodes.Add("158 Seasidey");
            enemyTree.Nodes.Add("HIDDEN Seasidey");
            enemyTree.Nodes.Add("159 Timberey");
            enemyTree.Nodes.Add("160 Judasey");
            enemyTree.Nodes.Add("161 Poisey");
            enemyTree.Nodes.Add("162 Polwigle");
            enemyTree.Nodes.Add("163 Peepit");
            enemyTree.Nodes.Add("164 Thornwigle");
            enemyTree.Nodes.Add("165 Bunwigle");
            enemyTree.Nodes.Add("166 Minicoid                Test Dummy 2");
            enemyTree.Nodes.Add("167 Ratwigle");
            enemyTree.Nodes.Add("168 Squirrigle");
            enemyTree.Nodes.Add("169 Gobligle");
            enemyTree.Nodes.Add("170 Axigle");
            enemyTree.Nodes.Add("171 Whitigle");
            enemyTree.Nodes.Add("172 Merfish");
            enemyTree.Nodes.Add("173 Albino Merfish");
            enemyTree.Nodes.Add("174 Electrifish");
            enemyTree.Nodes.Add("175 Predafish");
            enemyTree.Nodes.Add("176 Teethee");
            enemyTree.Nodes.Add("177 Lizardman");
            enemyTree.Nodes.Add("178 Strong Lizard");
            enemyTree.Nodes.Add("179 Boost Merfish");
            enemyTree.Nodes.Add("180 Gigafish");
            enemyTree.Nodes.Add("181 Wolf");
            enemyTree.Nodes.Add("182 Wolf (Aersick)");
            enemyTree.Nodes.Add("183 Black Wolf");
            enemyTree.Nodes.Add("184 Wirbel");
            enemyTree.Nodes.Add("185 Critis");
            enemyTree.Nodes.Add("186 Cornus");
            enemyTree.Nodes.Add("187 Lupice");
            enemyTree.Nodes.Add("188 Loewe");
            enemyTree.Nodes.Add("189 Schwert");
            enemyTree.Nodes.Add("190 Rhinossus");
            enemyTree.Nodes.Add("191 Rhinossus");
            enemyTree.Nodes.Add("192 Rhino");
            enemyTree.Nodes.Add("193 Black Rhino");
            enemyTree.Nodes.Add("194 EX Rhino");
            enemyTree.Nodes.Add("195 Tiredillo");
            enemyTree.Nodes.Add("196 Wild Boar");
            enemyTree.Nodes.Add("197 Spikadillo");
            enemyTree.Nodes.Add("198 Hippo");
            enemyTree.Nodes.Add("199 Generator Boar");
            enemyTree.Nodes.Add("200 Gullinbursti");
            enemyTree.Nodes.Add("201 Slidrugtanni");
            enemyTree.Nodes.Add("202 Swordbeak");
            enemyTree.Nodes.Add("203 Axe Beak");
            enemyTree.Nodes.Add("204 Axe Beak (Aersick)");
            enemyTree.Nodes.Add("205 Heavy Bottom");
            enemyTree.Nodes.Add("206 Rabbio");
            enemyTree.Nodes.Add("207 Dragon Gramps");
            enemyTree.Nodes.Add("208 Fantail");
            enemyTree.Nodes.Add("209 Rabbigo");
            enemyTree.Nodes.Add("210 Bugle Beak");
            enemyTree.Nodes.Add("211 Blade Beak");
            enemyTree.Nodes.Add("212 Quietta");
            enemyTree.Nodes.Add("213 Rhybgaro");
            enemyTree.Nodes.Add("214 Rhybgaro");
            enemyTree.Nodes.Add("215 Rhybgaro Memory");
            enemyTree.Nodes.Add("216 Uniceros");
            enemyTree.Nodes.Add("217 Mounico");
            enemyTree.Nodes.Add("218 EX Unicorn");
            enemyTree.Nodes.Add("219 Egg Bear");
            enemyTree.Nodes.Add("220 Egg Bear (Aersick)");
            enemyTree.Nodes.Add("221 Beast Bear");
            enemyTree.Nodes.Add("222 Square Shoulder");
            enemyTree.Nodes.Add("223 Wrath Nail");
            enemyTree.Nodes.Add("224 Skinny");
            enemyTree.Nodes.Add("225 Grimza");
            enemyTree.Nodes.Add("226 Heavy Bear");
            enemyTree.Nodes.Add("227 War Wolf");
            enemyTree.Nodes.Add("228 Bloodclaw Wolf");
            enemyTree.Nodes.Add("229 Basilisk");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("230 Black Basilisk");
            enemyTree.Nodes.Add("231 Spinosaurus");
            enemyTree.Nodes.Add("232 Cockatrice");
            enemyTree.Nodes.Add("233 Passion Cockatrice");
            enemyTree.Nodes.Add("234 Skunky");
            enemyTree.Nodes.Add("235 Greater Skunky");
            enemyTree.Nodes.Add("236 Great Cockatrice");
            enemyTree.Nodes.Add("237 Balloon Ghost");
            enemyTree.Nodes.Add("238 Jet Balloon");
            enemyTree.Nodes.Add("239 Floating Filo");
            enemyTree.Nodes.Add("240 Rosa Gigantia");
            enemyTree.Nodes.Add("241 Strange Bat");
            enemyTree.Nodes.Add("242 Fancy Parasol");
            enemyTree.Nodes.Add("243 Snow Spirit");
            enemyTree.Nodes.Add("244 Bigger Balloon");
            enemyTree.Nodes.Add("245 Poltergeist");
            enemyTree.Nodes.Add("246 Hysteric Purple");
            enemyTree.Nodes.Add("247 Tentacler");
            enemyTree.Nodes.Add("248 Octopoise");
            enemyTree.Nodes.Add("249 Fire Spirit");
            enemyTree.Nodes.Add("250 Flame Spirit");
            enemyTree.Nodes.Add("251 Ice Spirit");
            enemyTree.Nodes.Add("252 Crystal Spirit");
            enemyTree.Nodes.Add("253 Core Spirit");
            enemyTree.Nodes.Add("254 Anchorgeist");
            enemyTree.Nodes.Add("255 Beetle");
            enemyTree.Nodes.Add("256 Giant Beetle");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("257 Cheiron");
            enemyTree.Nodes.Add("258 Sawtosaw");
            enemyTree.Nodes.Add("259 Silver Stag");
            enemyTree.Nodes.Add("260 Gaina Firefly");
            enemyTree.Nodes.Add("261 Gold Beetle");
            enemyTree.Nodes.Add("262 Bee ");
            enemyTree.Nodes.Add("263 Giant Bee Aersick");
            enemyTree.Nodes.Add("264 Sonic Bee");
            enemyTree.Nodes.Add("265 Killer Bee");
            enemyTree.Nodes.Add("266 Killing Cupid");
            enemyTree.Nodes.Add("267 Gun Hornet");
            enemyTree.Nodes.Add("268 Grasshopper");
            enemyTree.Nodes.Add("269 Death Mantis");
            enemyTree.Nodes.Add("270 Nuggethopper");
            enemyTree.Nodes.Add("271 Flora Mantis");
            enemyTree.Nodes.Add("272 Giant Manis");
            enemyTree.Nodes.Add("273 Chimera Sister");
            enemyTree.Nodes.Add("274 Chimera Brother");
            enemyTree.Nodes.Add("275 Gentleman");
            enemyTree.Nodes.Add("276 Gentlematch");
            enemyTree.Nodes.Add("277 Gentlereplica");
            enemyTree.Nodes.Add("278 Gentlereplica Team Battle");
            enemyTree.Nodes.Add("279 Gentlesinger");
            enemyTree.Nodes.Add("280 Gentlesinger  Team Battle");
            enemyTree.Nodes.Add("281 Gentlemieu");
            enemyTree.Nodes.Add("282 Gentlemieu Team Battle");
            enemyTree.Nodes.Add("283 Golem");
            enemyTree.Nodes.Add("284 Gear Golem");
            enemyTree.Nodes.Add("285 Hammer Golem");
            enemyTree.Nodes.Add("286 Ice Golem");
            enemyTree.Nodes.Add("287 Gentlegolem");
            enemyTree.Nodes.Add("288 Gentlegolem Team Battle");
            enemyTree.Nodes.Add("289 Fake");
            enemyTree.Nodes.Add("290 Seed");
            enemyTree.Nodes.Add("291 Capiora");
            enemyTree.Nodes.Add("292 Pandor");
            enemyTree.Nodes.Add("293 Quadra");
            enemyTree.Nodes.Add("294 Murder");
            enemyTree.Nodes.Add("295 Blade Murder");
            enemyTree.Nodes.Add("296 Perfect Murder");
            enemyTree.Nodes.Add("297 Guilty Murder");
            enemyTree.Nodes.Add("298 Trans Murder");
            enemyTree.Nodes.Add("299 Amenti");
            enemyTree.Nodes.Add("300 Naraka");
            enemyTree.Nodes.Add("301 Hellish");
            enemyTree.Nodes.Add("302 Sheol");
            enemyTree.Nodes.Add("303 Yomi");
            enemyTree.Nodes.Add("304 Valhalla");
            enemyTree.Nodes.Add("305 Osiris");
            enemyTree.Nodes.Add("306 Kur");
            enemyTree.Nodes.Add("307 Brunhilde");
            enemyTree.Nodes.Add("308 Orpheus");
            enemyTree.Nodes.Add("309 Mandragora");
            enemyTree.Nodes.Add("310 Mandragora Aersick");
            enemyTree.Nodes.Add("311 Agaric");
            enemyTree.Nodes.Add("312 Dryad");
            enemyTree.Nodes.Add("313 Alraune");
            enemyTree.Nodes.Add("314 Mandrawigle");
            enemyTree.Nodes.Add("315 Tweeny");
            enemyTree.Nodes.Add("316 Superstar R");
            enemyTree.Nodes.Add("317 Superstar R Team Battle");
            enemyTree.Nodes.Add("318 Superstar B");
            enemyTree.Nodes.Add("319 Superstar B Team Battle");
            enemyTree.Nodes.Add("320 Superstar G");
            enemyTree.Nodes.Add("321 Superstar G Team Battle");
            enemyTree.Nodes.Add("322 Superstar O");
            enemyTree.Nodes.Add("323 Superstar O (Team Battle)");
            enemyTree.Nodes.Add("324 Superstar D");
            enemyTree.Nodes.Add("325 Superstar D Team Battle");
            enemyTree.Nodes.Add("326 Superstar S");
            enemyTree.Nodes.Add("327 Superstar  Team BattleS");
            enemyTree.Nodes.Add("328 Green Roper");
            enemyTree.Nodes.Add("329 Red Roper");
            enemyTree.Nodes.Add("330 Blue Roper");
            enemyTree.Nodes.Add("331 Yellow Roper");
            enemyTree.Nodes.Add("332 Goliath");
            enemyTree.Nodes.Add("333 Goliath Memory");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("334 Poseidon");
            enemyTree.Nodes.Add("335 Poseidon Memory");
            enemyTree.Nodes.Add("336 Gattuso");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("337 Gattuso Memory");
            enemyTree.Nodes.Add("338 Gattuso Cub");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("339 Gattuso Memory");
            enemyTree.Nodes.Add("340 Green Menace");
            enemyTree.Nodes.Add("341 Green Menace Memory");
            enemyTree.Nodes.Add("342 Fenrir");
            enemyTree.Nodes.Add("343 Fenrir Memory");
            enemyTree.Nodes.Add("344 Dreaded Giant");
            enemyTree.Nodes.Add("345 Gusios");
            enemyTree.Nodes.Add("346 Gusios Memory");
            enemyTree.Nodes.Add("347 Gigalarva");
            enemyTree.Nodes.Add("348 Gigalarva Memory");
            enemyTree.Nodes.Add("349 Cursed Wanderer");
            enemyTree.Nodes.Add("350 Cursed Wanderer");
            enemyTree.Nodes.Add("351 Cursed Wanderer Memory");
            enemyTree.Nodes.Add("352 Hermit Drill");
            enemyTree.Nodes.Add("353 Hermit Memory");
            enemyTree.Nodes.Add("354 Pteropus");
            enemyTree.Nodes.Add("355 Attack Bat");
            enemyTree.Nodes.Add("356 Magic Bat");
            enemyTree.Nodes.Add("357 Leader Bat");
            enemyTree.Nodes.Add("358 Pteropus Memory");
            enemyTree.Nodes.Add("359 Attack Bat Memory");
            enemyTree.Nodes.Add("360 Magic Bat Memory");
            enemyTree.Nodes.Add("361 Leader Bat Memory");
            enemyTree.Nodes.Add("362 Pterobronc");
            enemyTree.Nodes.Add("363 Pterobronc Memory");
            enemyTree.Nodes.Add("364 Outbreaker");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("365 Breaker Memory");
            enemyTree.Nodes.Add("366 Daybreaker");
            enemyTree.Nodes.Add("367 Nightbreaker");
            enemyTree.Nodes.Add("368 Belius");
            enemyTree.Nodes.Add("369 Belius Memory");
            enemyTree.Nodes.Add("370 Belius Double");
            enemyTree.Nodes.Add("371 Baitojoh");
            enemyTree.Nodes.Add("372 Baitojoh");
            enemyTree.Nodes.Add("373 Khroma Dragon");
            enemyTree.Nodes.Add("374 Khroma Memory");
            enemyTree.Nodes.Add("375 Griffin");
            enemyTree.Nodes.Add("376 Griffin Memory");
            enemyTree.Nodes.Add("377 Chimera Butterfly");
            enemyTree.Nodes.Add("378 Chimera Memory");
            enemyTree.Nodes.Add("379 Medusa Butterfly");
            enemyTree.Nodes.Add("380 Medusa Memory");
            enemyTree.Nodes.Add("381 Brutal");
            enemyTree.Nodes.Add("382 Brucis");
            enemyTree.Nodes.Add("383 Brucis Memory");
            enemyTree.Nodes.Add("384 Bloody Beak");
            enemyTree.Nodes.Add("385 Bloody Beak Memory");
            enemyTree.Nodes.Add("386 Ohma");
            enemyTree.Nodes.Add("387 Sword Dancer");
            enemyTree.Nodes.Add("388 Sword Dancer");
            enemyTree.Nodes.Add("389 Sword Dancer");
            enemyTree.Nodes.Add("390 Anubis");
            enemyTree.Nodes.Add("391 Izanami");
            enemyTree.Nodes.Add("392 Odin");
            enemyTree.Nodes.Add("393 Hades");
            enemyTree.Nodes.Add("394 Spiral Draco (Central Head)");
            enemyTree.Nodes.Add("395 Spiral Draco (Left Head)");
            enemyTree.Nodes.Add("396 Spiral Draco (Right Head)");
            enemyTree.Nodes.Add("397 Spiral Draco (Body)");
            enemyTree.Nodes.Add("398 Spiral Draco (Left Tail)");
            enemyTree.Nodes.Add("399 Spiral Draco (Right Tail)");
            enemyTree.Nodes.Add("400 Duke");
            enemyTree.Nodes.Add("401 Duke");
            enemyTree.Nodes.Add("402 Radiant Winged One");
            enemyTree.Nodes.Add("403 Duke Memory");
            enemyTree.Nodes.Add("404 Alexei");
            enemyTree.Nodes.Add("405 Alexei Memory");
            enemyTree.Nodes.Add("406 Barbos");
            enemyTree.Nodes.Add("407 Barbos Memory");
            enemyTree.Nodes.Add("408 Zagi");
            enemyTree.Nodes.Add("409 Zagi");
            enemyTree.Nodes.Add("410 Zagi");
            enemyTree.Nodes.Add("411 Zagi");
            enemyTree.Nodes.Add("412 Zagi");
            enemyTree.Nodes.Add("413 Zagi (New)");
            enemyTree.Nodes.Add("414 Zagi Memory");
            enemyTree.Nodes.Add("415 Yeager");
            enemyTree.Nodes.Add("416 Yeager");
            enemyTree.Nodes.Add("417 Yeager");
            enemyTree.Nodes.Add("418 Yeager Memory");
            enemyTree.Nodes.Add("419 Gauche");
            enemyTree.Nodes.Add("420 Droite");
            enemyTree.Nodes.Add("421 Gauche Coliseum");
            enemyTree.Nodes.Add("422 Droite Coliseum");
            enemyTree.Nodes.Add("423 Clint");
            enemyTree.Nodes.Add("424 Clint Coliseum");
            enemyTree.Nodes.Add("425 Clint of the Hunting Blades Team Battle");
            enemyTree.Nodes.Add("426 Clint Memory");
            enemyTree.Nodes.Add("427 Tison");
            enemyTree.Nodes.Add("428 Tison Coliseum");
            enemyTree.Nodes.Add("429 Tison of the Hunting Blades Team Battle");
            enemyTree.Nodes.Add("430 Tison Memory");
            enemyTree.Nodes.Add("431 Nan");
            enemyTree.Nodes.Add("432 Nan Coliseum");
            enemyTree.Nodes.Add("433 Nan Coliseum 2");
            enemyTree.Nodes.Add("434 Nan of the Hunting Blades Team Battle");
            enemyTree.Nodes.Add("435 Nan Memory");
            enemyTree.Nodes.Add("436 Don");
            enemyTree.Nodes.Add("437 Don Memory");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("438 Yuri Coliseum");
            enemyTree.Nodes.Add("439 Yuri Team Battle");
            enemyTree.Nodes.Add("440 Estellise");
            enemyTree.Nodes.Add("441 Estellise");
            enemyTree.Nodes.Add("442 Estellise Team Battle");
            enemyTree.Nodes.Add("443 Estellise Memory");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("444 King Kaboom");
            enemyTree.Nodes.Add("445 Karol Team Battle");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("446 Rita Team Battle");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("447 Raven Team Battle");
            enemyTree.Nodes.Add("448 Schwann");
            enemyTree.Nodes.Add("449 Schwann Team Battle");
            enemyTree.Nodes.Add("450 Schwann Memory");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("451 Judith Team Battle");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("452 Repede Team Battle");
            enemyTree.Nodes.Add("453 Flynn");
            enemyTree.Nodes.Add("454 Flynn");
            enemyTree.Nodes.Add("455 Flynn Coliseum");
            enemyTree.Nodes.Add("456 Flynn Team Battle");
            enemyTree.Nodes.Add("457 Flynn Memory");
            enemyTree.Nodes.Add("458 Patty Team Battle");
            enemyTree.Nodes.Add("459 Adecor         Event 1");
            enemyTree.Nodes.Add("460 Boccos        Event 1");
            enemyTree.Nodes.Add("461 Adecor");
            enemyTree.Nodes.Add("462 Boccos");
            enemyTree.Nodes.Add("463 Adecor");
            enemyTree.Nodes.Add("464 Boccos");
            enemyTree.Nodes.Add("465 Adecor Coliseum");
            enemyTree.Nodes.Add("466 Boccos Coliseum");
            enemyTree.Nodes.Add("467 Adecor Team Battle");
            enemyTree.Nodes.Add("468 Boccos Team Battle");
            enemyTree.Nodes.Add("469 Adecor Memory");
            enemyTree.Nodes.Add("470 Boccos Memory");
            enemyTree.Nodes.Add("471 Leblanc Team Battle");
            enemyTree.Nodes.Add("472 Traitor to Heaven");
            enemyTree.Nodes.Add("473 Traitor To Heaven");
            enemyTree.Nodes.Add("474 Traitor To Heaven Team Battle");
            enemyTree.Nodes.Add("475 Killer of Heroes");
            enemyTree.Nodes.Add("476 Killer of Heroes Team Battle");
            enemyTree.Nodes.Add("477 Time Traveller");
            enemyTree.Nodes.Add("478 Time Traveller Team Battle");
            enemyTree.Nodes.Add("479 Sorrowful Queen of Darkness");
            enemyTree.Nodes.Add("480 Sorrowful Queen of Darkness Team Battle");
            enemyTree.Nodes.Add("HIDDEN Billybally Leaf (Gattsuo)");
            enemyTree.Nodes.Add("HIDDEN Bridge Support?");
            enemyTree.Nodes.Add("HIDDEN Lamp?");
            enemyTree.Nodes.Add("HIDDEN Karalow X?");
            enemyTree.Nodes.Add("HIDDEN Treasure Chest (Blue)");
            enemyTree.Nodes.Add("HIDDEN Treasure Chest (Red)");
            enemyTree.Nodes.Add("HIDDEN Treasure Chest (Light)");
            enemyTree.Nodes.Add("HIDDEN Treasure Chest (Dark)");
            enemyTree.Nodes.Add("HIDDEN Treasure Chest (Mystery)");



            TreeNodeCollection nodeCollect = enemyTree.Nodes;
            enemyTree.SelectedNode = nodeCollect[0];
        }

        private void FormVesperiaEnemyEditor_Load(object sender, EventArgs e)
        {

        }

        private void enemyTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            richTextBoxLv.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 100).ToString("D");  //Value 1 is distance / offset from the start of the file to the start of the array ("Start" in 010) (The first byte is 0) 
            richTextBoxMaxHP.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 104).ToString("D");  //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)
            richTextBoxMaxTP.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 108).ToString("D");  //Value 2 is how many bytes / hexes are in a "row"   (First byte is 1 NOT 0)

            richTextBoxPAtk.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 112).ToString("D");//Value 3 is how many bytes into the row info starts (The first byte is byte 0)
            richTextBoxPDef.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 116).ToString("D"); 
            richTextBoxMAtk.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 120).ToString("D");
            richTextBoxMDef.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 124).ToString("D");
            richTextBoxAgi.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 132).ToString("D");

            richTextBoxFamily.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 168).ToString("D");

            richTextBoxFire.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 176).ToString("D");
            richTextBoxEarth.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 180).ToString("D");
            richTextBoxWind.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 184).ToString("D");
            richTextBoxWater.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 188).ToString("D");
            richTextBoxLight.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 192).ToString("D");
            richTextBoxDark.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 196).ToString("D");
            richTextBoxDArms.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 200).ToString("D");

            richTextBoxExp.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 204).ToString("D");
            richTextBoxGald.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 208).ToString("D");
            richTextBoxLP.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 212).ToString("D");

            richTextBoxUnknown1.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 128).ToString("D");
            richTextBoxUnknown2.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 172).ToString("D");


            richTextBoxUnknown4.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 216).ToString("D");
            richTextBoxUnknown5.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 220).ToString("D");
            richTextBoxUnknown6.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 224).ToString("D");
            richTextBoxUnknown7.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 228).ToString("D");
            richTextBoxUnknown8.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 232).ToString("D");
            richTextBoxUnknown9.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 236).ToString("D");
            richTextBoxUnknown10.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 240).ToString("D");
            richTextBoxUnknown11.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 244).ToString("D");
            richTextBoxUnknown12.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 248).ToString("D");
            richTextBoxUnknown13.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 252).ToString("D");
            richTextBoxUnknown14.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 256).ToString("D");
            richTextBoxUnknown15.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 260).ToString("D");
            richTextBoxUnknown16.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 264).ToString("D");
            richTextBoxUnknown17.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 268).ToString("D");
            richTextBoxUnknown18.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 272).ToString("D");
            richTextBoxUnknown19.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 276).ToString("D");
            richTextBoxUnknown20.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 280).ToString("D");
            richTextBoxUnknown21.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 284).ToString("D");
            richTextBoxUnknown22.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 288).ToString("D");
            richTextBoxUnknown23.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 292).ToString("D");
            richTextBoxUnknown24.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 296).ToString("D");
            richTextBoxUnknown25.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 300).ToString("D");
            richTextBoxUnknown26.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 304).ToString("D");
            richTextBoxUnknown27.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 308).ToString("D");
            richTextBoxUnknown28.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 312).ToString("D");
            richTextBoxUnknown29.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 320).ToString("D");

            richTextBoxUnknown30.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 164).ToString("D");
            richTextBoxUnknown31.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 136).ToString("D");
            richTextBoxUnknown32.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 88).ToString("D");
            richTextBoxUnknown33.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 28).ToString("D");
            richTextBoxUnknown34.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 24).ToString("D");
            richTextBoxUnknown35.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 140).ToString("D");
            richTextBoxUnknown36.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 144).ToString("D");
            richTextBoxUnknown37.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 148).ToString("D");
            richTextBoxUnknown38.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 0).ToString("D");
            richTextBoxUnknown39.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 4).ToString("D");
            richTextBoxUnknown40.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 8).ToString("D");
            richTextBoxUnknown41.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 12).ToString("D");
            richTextBoxUnknown42.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 16).ToString("D");
            richTextBoxUnknown43.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 20).ToString("D");

            richTextBoxUnknown44.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 32).ToString("D");
            richTextBoxUnknown45.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 36).ToString("D");
            richTextBoxUnknown46.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 40).ToString("D");
            richTextBoxUnknown47.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 44).ToString("D");
            richTextBoxUnknown48.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 48).ToString("D");
            richTextBoxUnknown49.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 52).ToString("D");
            richTextBoxUnknown50.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 56).ToString("D");
            richTextBoxUnknown51.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 60).ToString("D");
            richTextBoxUnknown52.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 68).ToString("D");
            richTextBoxUnknown53.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 72).ToString("D");
            richTextBoxUnknown54.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 80).ToString("D");
            richTextBoxUnknown55.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 92).ToString("D");
            richTextBoxBattleBook.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 316).ToString("D");
            richTextBoxUnknown56.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 324).ToString("D");


            richTextBoxEMaxHP.Text = Convert.ToString(Convert.ToInt32(richTextBoxMaxHP.Text) * 0.7);
            richTextBoxEPAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxPAtk.Text) * 0.7);
            richTextBoxEPDef.Text = Convert.ToString(Convert.ToInt32(richTextBoxPDef.Text) * 0.7);
            richTextBoxEMAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxMAtk.Text) * 0.7);
            richTextBoxEMDef.Text = Convert.ToString(Convert.ToInt32(richTextBoxMDef.Text) * 0.7);

            richTextBoxHMaxHP.Text = Convert.ToString(Convert.ToInt32(richTextBoxMaxHP.Text) * 2.5);
            richTextBoxHPAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxPAtk.Text) * 1.2);
            richTextBoxHMAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxMAtk.Text) * 1.2);
            
            richTextBoxUMaxHP.Text = Convert.ToString(Convert.ToInt32(richTextBoxMaxHP.Text) * 5);
            richTextBoxUPAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxPAtk.Text) * 3.5);
            richTextBoxUPDef.Text = Convert.ToString(Convert.ToInt32(richTextBoxPDef.Text) * 2.5);
            richTextBoxUMAtk.Text = Convert.ToString(Convert.ToInt32(richTextBoxMAtk.Text) * 3);
            richTextBoxUMDef.Text = Convert.ToString(Convert.ToInt32(richTextBoxMDef.Text) * 2.5);

        }

        private void button1_Click(object sender, EventArgs e) //Save Button
        {
            //B! .TryParse(Name! .Text, out type! value! ); { Form1.ByteWriter( value! , enemydata_array, StartingHex! + (treeView1.SelectedNode.Index * RowSize! ) + ArrayOfset! ); }
            //B=Byte size, 1="Byte" 2="UInt16" 4="UInt32"         Name!=the name of the textbox        type!= byte / ushort / uint, only include this in the FIRST time this ever happens in a form, later copies ommit this!
            //value!=Name of variable that holds the byte type (so byte/short/int has diffrent names)       StartingHex!= The hex offset      RowSize!=How many bytes in a row    Arrayofset! = how far into the row do we start grabbing info or saving it

            //Byte.TryParse(textBoxLv.Text, out byte value8); { Form1.ByteWriter(value8, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 1); } //First 1 byte save    currently unused
            //UInt16.TryParse(textBoxOther.Text, out ushort value16); { Form1.ByteWriter(value16, enemydata_array, 99 + (enemyTree.SelectedNode.Index * 100) + 3); } //First 2 byte save   currently unused

            UInt32.TryParse(richTextBoxLv.Text, out uint value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 100); } //First 4 byte save
            UInt32.TryParse(richTextBoxMaxHP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 104); } 
            UInt32.TryParse(richTextBoxMaxTP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 108); } 

            UInt32.TryParse(richTextBoxPAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 112); } 
            UInt32.TryParse(richTextBoxPDef.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 116); } 
            UInt32.TryParse(richTextBoxMAtk.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 120); } 
            UInt32.TryParse(richTextBoxMDef.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 124); } 
            UInt32.TryParse(richTextBoxAgi.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 132); }

            UInt32.TryParse(richTextBoxFamily.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 168); }

            UInt32.TryParse(richTextBoxFire.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 176); }
            UInt32.TryParse(richTextBoxEarth.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 180); }
            UInt32.TryParse(richTextBoxWind.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 184); }
            UInt32.TryParse(richTextBoxWater.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 188); }
            UInt32.TryParse(richTextBoxLight.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 192); }
            UInt32.TryParse(richTextBoxDark.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 196); }
            UInt32.TryParse(richTextBoxDArms.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 200); }

            UInt32.TryParse(richTextBoxExp.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 204); }
            UInt32.TryParse(richTextBoxGald.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 208); }
            UInt32.TryParse(richTextBoxLP.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 212); }

            UInt32.TryParse(richTextBoxUnknown1.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 128); }
            UInt32.TryParse(richTextBoxUnknown2.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 172); }

            UInt32.TryParse(richTextBoxUnknown4.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 216); }
            UInt32.TryParse(richTextBoxUnknown5.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 220); }
            UInt32.TryParse(richTextBoxUnknown6.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 224); }
            UInt32.TryParse(richTextBoxUnknown7.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 228); }
            UInt32.TryParse(richTextBoxUnknown8.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 232); }
            UInt32.TryParse(richTextBoxUnknown9.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 236); }
            UInt32.TryParse(richTextBoxUnknown10.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 240); }
            UInt32.TryParse(richTextBoxUnknown11.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 244); }
            UInt32.TryParse(richTextBoxUnknown12.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 248); }
            UInt32.TryParse(richTextBoxUnknown13.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 252); }
            UInt32.TryParse(richTextBoxUnknown14.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 256); }
            UInt32.TryParse(richTextBoxUnknown15.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 260); }
            UInt32.TryParse(richTextBoxUnknown16.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 264); }
            UInt32.TryParse(richTextBoxUnknown17.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 268); }
            UInt32.TryParse(richTextBoxUnknown18.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 272); }
            UInt32.TryParse(richTextBoxUnknown19.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 276); }
            UInt32.TryParse(richTextBoxUnknown20.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 280); }
            UInt32.TryParse(richTextBoxUnknown21.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 284); }
            UInt32.TryParse(richTextBoxUnknown22.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 288); }
            UInt32.TryParse(richTextBoxUnknown23.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 292); }
            UInt32.TryParse(richTextBoxUnknown24.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 296); }
            UInt32.TryParse(richTextBoxUnknown25.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 300); }
            UInt32.TryParse(richTextBoxUnknown26.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 304); }
            UInt32.TryParse(richTextBoxUnknown27.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 308); }
            UInt32.TryParse(richTextBoxUnknown28.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 312); }
            UInt32.TryParse(richTextBoxUnknown29.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 320); }


            UInt32.TryParse(richTextBoxUnknown30.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 164); }
            UInt32.TryParse(richTextBoxUnknown30.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 136); }
            UInt32.TryParse(richTextBoxUnknown32.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 88); }
            UInt32.TryParse(richTextBoxUnknown33.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 28); }
            UInt32.TryParse(richTextBoxUnknown34.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 24); }
            UInt32.TryParse(richTextBoxUnknown35.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 140); }
            UInt32.TryParse(richTextBoxUnknown36.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 144); }
            UInt32.TryParse(richTextBoxUnknown37.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 148); }

            UInt32.TryParse(richTextBoxUnknown38.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 0); }
            UInt32.TryParse(richTextBoxUnknown39.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 4); }
            UInt32.TryParse(richTextBoxUnknown40.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 8); }
            UInt32.TryParse(richTextBoxUnknown41.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 12); }
            UInt32.TryParse(richTextBoxUnknown42.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 16); }
            UInt32.TryParse(richTextBoxUnknown43.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 20); }

            UInt32.TryParse(richTextBoxUnknown44.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 32); }
            UInt32.TryParse(richTextBoxUnknown45.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 36); }
            UInt32.TryParse(richTextBoxUnknown46.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 40); }
            UInt32.TryParse(richTextBoxUnknown47.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 44); }
            UInt32.TryParse(richTextBoxUnknown48.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 48); }
            UInt32.TryParse(richTextBoxUnknown49.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 52); }
            UInt32.TryParse(richTextBoxUnknown50.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 56); }
            UInt32.TryParse(richTextBoxUnknown51.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 60); }
            UInt32.TryParse(richTextBoxUnknown52.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 68); }
            UInt32.TryParse(richTextBoxUnknown53.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 72); }
            UInt32.TryParse(richTextBoxUnknown54.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 80); }
            UInt32.TryParse(richTextBoxUnknown55.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 92); }
            UInt32.TryParse(richTextBoxBattleBook.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 316); }
            UInt32.TryParse(richTextBoxUnknown56.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 324); }
            

            File.WriteAllBytes(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo", enemydata_array); //saves to the path i set, everything in the array/        
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //Arte Editor Button
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaArteEditor f2 = new FormVesperiaArteEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button6_Click(object sender, EventArgs e) //Skill Editor
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo"))
            {
                FormVesperiaSkillEditor f2 = new FormVesperiaSkillEditor(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void button2_Click(object sender, EventArgs e) //Items and Equipment
        {
            if (File.Exists(Properties.Settings.Default.VesperiaData64 + "\\Data64\\item.svo"))
            {
                FormVesperiaItem f2 = new FormVesperiaItem(); //Create the new form
                f2.StartPosition = FormStartPosition.Manual;  //Grab current windows location
                f2.Location = this.Location; //Create the new window at the same location as current one
                f2.Show(); //Show the new window
                this.Close(); //Close the current window
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("The mod directory is not set");
            }
        }

        private void label10_Click(object sender, EventArgs e) //LP text
        {
            richTextBoxInfoBox.Text = "LP is the EXP required by skills." +
                "When a skill gets enough LP, it is permenantly learned.";
        }

        private void label11_Click(object sender, EventArgs e) //Fire text
        {
            richTextBoxInfoBox.Text = "Elements are %Magic Damage recieved" +
                "max weakness is 255 %" +
                "You can absorb by underflow to max of - 255 % " +
                "Magic damage is ANY damage based on your magic stat," +
                "not only spell damage." +
                "by default, all elemental artes are atleast somewhat magical.";
               
        }

        private void label21_Click(object sender, EventArgs e) //Darms text
        {
            richTextBoxInfoBox.Text = "This is the devil arms." +
                "By default, only the spiral draco is immune to them." +
                "It doesn't seem like any other weapons can get the" +
                "devil arms property, so it's actually only devil arms." +
                "The D arms element is not shown on weapons or battle book." +
                "" +
                "PS the D arms are end-game weapons that get +1 damage every" +
                "time the user gets a kill.";
        }

        private void label22_Click_1(object sender, EventArgs e) //To Do List
        {
            richTextBoxInfoBox.Text = "Secret mission drop" +
                "Secret mission codition" +
                "Iron Stance" +
                "Model#" +
                "AI setting?";
        }
    }
}
