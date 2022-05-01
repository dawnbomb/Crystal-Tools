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
        String treeloaded = "No";
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
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("3 Knight Fencer A");
            enemyTree.Nodes.Add("4 Knight Fencer F");
            enemyTree.Nodes.Add("5 Knight Fencer K");
            enemyTree.Nodes.Add("6 Knight Fencer S");
            enemyTree.Nodes.Add("HIDDEN Knight Fencer H");
            enemyTree.Nodes.Add("7 Knight Warrior A");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("8 Grain");
            enemyTree.Nodes.Add("9 Knight Lancer");
            enemyTree.Nodes.Add("10 Knight Catcher");
            enemyTree.Nodes.Add("11 Knight Halberd");
            enemyTree.Nodes.Add("12 Knight Halberd A");
            enemyTree.Nodes.Add("13 Knight Halberd F");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("14 Erungar");
            enemyTree.Nodes.Add("15 Erungar (Team Battle)");
            enemyTree.Nodes.Add("16 Erungar Memory");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("17 Knight Lancer A");
            enemyTree.Nodes.Add("HIDDEN ");
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
            enemyTree.Nodes.Add("71 Filifolia Bud");
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
            enemyTree.Nodes.Add("166 Minicoid");
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
            enemyTree.Nodes.Add("229 Skunky");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("230 ");
            enemyTree.Nodes.Add("231 ");
            enemyTree.Nodes.Add("232 ");
            enemyTree.Nodes.Add("233 ");
            enemyTree.Nodes.Add("234 ");
            enemyTree.Nodes.Add("235 ");
            enemyTree.Nodes.Add("236 Great Cockatrice");
            enemyTree.Nodes.Add("237 ");
            enemyTree.Nodes.Add("238 ");
            enemyTree.Nodes.Add("239 ");
            enemyTree.Nodes.Add("240 ");
            enemyTree.Nodes.Add("241 ");
            enemyTree.Nodes.Add("242 ");
            enemyTree.Nodes.Add("243 ");
            enemyTree.Nodes.Add("244 ");
            enemyTree.Nodes.Add("245 ");
            enemyTree.Nodes.Add("246 ");
            enemyTree.Nodes.Add("247 ");
            enemyTree.Nodes.Add("248 ");
            enemyTree.Nodes.Add("249 ");
            enemyTree.Nodes.Add("250 ");
            enemyTree.Nodes.Add("251 ");
            enemyTree.Nodes.Add("252 ");
            enemyTree.Nodes.Add("253 ");
            enemyTree.Nodes.Add("254 ");
            enemyTree.Nodes.Add("255 ");
            enemyTree.Nodes.Add("256 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("257 ");
            enemyTree.Nodes.Add("258 ");
            enemyTree.Nodes.Add("259 ");
            enemyTree.Nodes.Add("260 ");
            enemyTree.Nodes.Add("261 ");
            enemyTree.Nodes.Add("262 ");
            enemyTree.Nodes.Add("263 ");
            enemyTree.Nodes.Add("264 ");
            enemyTree.Nodes.Add("265 ");
            enemyTree.Nodes.Add("266 ");
            enemyTree.Nodes.Add("267 ");
            enemyTree.Nodes.Add("268 ");
            enemyTree.Nodes.Add("269 ");
            enemyTree.Nodes.Add("270 ");
            enemyTree.Nodes.Add("271 ");
            enemyTree.Nodes.Add("272 ");
            enemyTree.Nodes.Add("273 Chimera Sister");
            enemyTree.Nodes.Add("274 Chimera Brother");
            enemyTree.Nodes.Add("275 ");
            enemyTree.Nodes.Add("276 ");
            enemyTree.Nodes.Add("277 ");
            enemyTree.Nodes.Add("278 ");
            enemyTree.Nodes.Add("279 ");
            enemyTree.Nodes.Add("280 ");
            enemyTree.Nodes.Add("281 ");
            enemyTree.Nodes.Add("282 ");
            enemyTree.Nodes.Add("283 ");
            enemyTree.Nodes.Add("284 ");
            enemyTree.Nodes.Add("285 ");
            enemyTree.Nodes.Add("286 ");
            enemyTree.Nodes.Add("287 ");
            enemyTree.Nodes.Add("288 ");
            enemyTree.Nodes.Add("289 ");
            enemyTree.Nodes.Add("290 ");
            enemyTree.Nodes.Add("291 ");
            enemyTree.Nodes.Add("292 ");
            enemyTree.Nodes.Add("293 ");
            enemyTree.Nodes.Add("294 ");
            enemyTree.Nodes.Add("295 ");
            enemyTree.Nodes.Add("296 ");
            enemyTree.Nodes.Add("297 ");
            enemyTree.Nodes.Add("298 ");
            enemyTree.Nodes.Add("299 ");
            enemyTree.Nodes.Add("300 ");
            enemyTree.Nodes.Add("301 ");
            enemyTree.Nodes.Add("302 Sheol");
            enemyTree.Nodes.Add("303 Yomi");
            enemyTree.Nodes.Add("304 Valhalla");
            enemyTree.Nodes.Add("305 Osiris");
            enemyTree.Nodes.Add("306 Kur");
            enemyTree.Nodes.Add("307 Brunhilde");
            enemyTree.Nodes.Add("308 Orpheus");
            enemyTree.Nodes.Add("309 ");
            enemyTree.Nodes.Add("310 ");
            enemyTree.Nodes.Add("311 ");
            enemyTree.Nodes.Add("312 ");
            enemyTree.Nodes.Add("313 ");
            enemyTree.Nodes.Add("314 ");
            enemyTree.Nodes.Add("315 ");
            enemyTree.Nodes.Add("316 ");
            enemyTree.Nodes.Add("317 ");
            enemyTree.Nodes.Add("318 ");
            enemyTree.Nodes.Add("319 ");
            enemyTree.Nodes.Add("320 ");
            enemyTree.Nodes.Add("321 ");
            enemyTree.Nodes.Add("322 ");
            enemyTree.Nodes.Add("323 Superstar O (Team Battle)");
            enemyTree.Nodes.Add("324 ");
            enemyTree.Nodes.Add("325 ");
            enemyTree.Nodes.Add("326 ");
            enemyTree.Nodes.Add("327 ");
            enemyTree.Nodes.Add("328 ");
            enemyTree.Nodes.Add("329 ");
            enemyTree.Nodes.Add("330 ");
            enemyTree.Nodes.Add("331 ");
            enemyTree.Nodes.Add("332 ");
            enemyTree.Nodes.Add("333 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("334 ");
            enemyTree.Nodes.Add("335 ");
            enemyTree.Nodes.Add("336 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("337 ");
            enemyTree.Nodes.Add("338 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("339 ");
            enemyTree.Nodes.Add("340 ");
            enemyTree.Nodes.Add("341 ");
            enemyTree.Nodes.Add("342 ");
            enemyTree.Nodes.Add("343 ");
            enemyTree.Nodes.Add("344 ");
            enemyTree.Nodes.Add("345 ");
            enemyTree.Nodes.Add("346 ");
            enemyTree.Nodes.Add("347 ");
            enemyTree.Nodes.Add("348 ");
            enemyTree.Nodes.Add("349 ");
            enemyTree.Nodes.Add("350 ");
            enemyTree.Nodes.Add("351 ");
            enemyTree.Nodes.Add("352 ");
            enemyTree.Nodes.Add("353 ");
            enemyTree.Nodes.Add("354 ");
            enemyTree.Nodes.Add("355 ");
            enemyTree.Nodes.Add("356 ");
            enemyTree.Nodes.Add("357 ");
            enemyTree.Nodes.Add("358 ");
            enemyTree.Nodes.Add("359 ");
            enemyTree.Nodes.Add("360 ");
            enemyTree.Nodes.Add("361 ");
            enemyTree.Nodes.Add("362 ");
            enemyTree.Nodes.Add("363 ");
            enemyTree.Nodes.Add("364 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("365 ");
            enemyTree.Nodes.Add("366 ");
            enemyTree.Nodes.Add("367 ");
            enemyTree.Nodes.Add("368 ");
            enemyTree.Nodes.Add("369 Belius Memory");
            enemyTree.Nodes.Add("370 ");
            enemyTree.Nodes.Add("371 ");
            enemyTree.Nodes.Add("372 ");
            enemyTree.Nodes.Add("373 ");
            enemyTree.Nodes.Add("374 ");
            enemyTree.Nodes.Add("375 ");
            enemyTree.Nodes.Add("376 ");
            enemyTree.Nodes.Add("377 ");
            enemyTree.Nodes.Add("378 ");
            enemyTree.Nodes.Add("379 ");
            enemyTree.Nodes.Add("380 ");
            enemyTree.Nodes.Add("381 ");
            enemyTree.Nodes.Add("382 ");
            enemyTree.Nodes.Add("383 ");
            enemyTree.Nodes.Add("384 ");
            enemyTree.Nodes.Add("385 ");
            enemyTree.Nodes.Add("386 ");
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
            enemyTree.Nodes.Add("400 ");
            enemyTree.Nodes.Add("401 ");
            enemyTree.Nodes.Add("402 ");
            enemyTree.Nodes.Add("403 ");
            enemyTree.Nodes.Add("404 ");
            enemyTree.Nodes.Add("405 ");
            enemyTree.Nodes.Add("406 ");
            enemyTree.Nodes.Add("407 ");
            enemyTree.Nodes.Add("408 ");
            enemyTree.Nodes.Add("409 ");
            enemyTree.Nodes.Add("410 ");
            enemyTree.Nodes.Add("411 ");
            enemyTree.Nodes.Add("412 ");
            enemyTree.Nodes.Add("413 ");
            enemyTree.Nodes.Add("414 ");
            enemyTree.Nodes.Add("415 ");
            enemyTree.Nodes.Add("416 ");
            enemyTree.Nodes.Add("417 ");
            enemyTree.Nodes.Add("418 ");
            enemyTree.Nodes.Add("419 ");
            enemyTree.Nodes.Add("420 ");
            enemyTree.Nodes.Add("421 ");
            enemyTree.Nodes.Add("422 ");
            enemyTree.Nodes.Add("423 ");
            enemyTree.Nodes.Add("424 ");
            enemyTree.Nodes.Add("425 ");
            enemyTree.Nodes.Add("426 ");
            enemyTree.Nodes.Add("427 ");
            enemyTree.Nodes.Add("428 ");
            enemyTree.Nodes.Add("429 ");
            enemyTree.Nodes.Add("430 ");
            enemyTree.Nodes.Add("431 ");
            enemyTree.Nodes.Add("432 ");
            enemyTree.Nodes.Add("433 ");
            enemyTree.Nodes.Add("434 ");
            enemyTree.Nodes.Add("435 ");
            enemyTree.Nodes.Add("436 ");
            enemyTree.Nodes.Add("437 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("438 ");
            enemyTree.Nodes.Add("439 ");
            enemyTree.Nodes.Add("440 ");
            enemyTree.Nodes.Add("441 ");
            enemyTree.Nodes.Add("442 ");
            enemyTree.Nodes.Add("443 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("444 ");
            enemyTree.Nodes.Add("445 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("446 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("447 ");
            enemyTree.Nodes.Add("448 ");
            enemyTree.Nodes.Add("449 ");
            enemyTree.Nodes.Add("450 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("451 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("452 ");
            enemyTree.Nodes.Add("453 ");
            enemyTree.Nodes.Add("454 ");
            enemyTree.Nodes.Add("455 ");
            enemyTree.Nodes.Add("456 ");
            enemyTree.Nodes.Add("457 ");
            enemyTree.Nodes.Add("458 ");
            enemyTree.Nodes.Add("459 ");
            enemyTree.Nodes.Add("460 ");
            enemyTree.Nodes.Add("461 ");
            enemyTree.Nodes.Add("462 ");
            enemyTree.Nodes.Add("463 ");
            enemyTree.Nodes.Add("464 ");
            enemyTree.Nodes.Add("465 ");
            enemyTree.Nodes.Add("466 ");
            enemyTree.Nodes.Add("467 ");
            enemyTree.Nodes.Add("468 ");
            enemyTree.Nodes.Add("469 ");
            enemyTree.Nodes.Add("470 ");
            enemyTree.Nodes.Add("471 ");
            enemyTree.Nodes.Add("472 ");
            enemyTree.Nodes.Add("473 ");
            enemyTree.Nodes.Add("474 ");
            enemyTree.Nodes.Add("475 ");
            enemyTree.Nodes.Add("476 ");
            enemyTree.Nodes.Add("477 ");
            enemyTree.Nodes.Add("478 ");
            enemyTree.Nodes.Add("479 ");
            enemyTree.Nodes.Add("480 ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");
            enemyTree.Nodes.Add("HIDDEN ");

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
            richTextBoxUnknown3.Text = BitConverter.ToUInt32(enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 200).ToString("D");

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
            UInt32.TryParse(richTextBoxUnknown3.Text, out value32); { Form1.ByteWriter(value32, enemydata_array, 82236641 + (enemyTree.SelectedNode.Index * 328) + 200); }

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

            File.WriteAllBytes(Properties.Settings.Default.VesperiaData64 + "\\Data64\\btl.svo", enemydata_array); //saves to the path i set, everything in the array/        
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
