using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "QuestBattle", columnHash: 0x7b274910 )]
    public class QuestBattle : IExcelRow
    {
        // column defs from Wed, 31 Jul 2019 22:24:05 GMT


        // col: 04 offset: 0000
        public string[] ScriptInstruction;

        // col: 204 offset: 0004
        public uint[] ScriptValue;

        // col: 00 offset: 0640
        public int Quest;

        // col: 02 offset: 0644
        public ushort TimeLimit;

        // col: 03 offset: 0646
        public ushort LevelSync;

        // col: 01 offset: 0648
        public byte QuestBattleScene;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 4 offset: 0000
            ScriptInstruction = new string[200];
            ScriptInstruction[0] = parser.ReadOffset< string >( 0x0 );
            ScriptInstruction[1] = parser.ReadOffset< string >( 0x8 );
            ScriptInstruction[2] = parser.ReadOffset< string >( 0x10 );
            ScriptInstruction[3] = parser.ReadOffset< string >( 0x18 );
            ScriptInstruction[4] = parser.ReadOffset< string >( 0x20 );
            ScriptInstruction[5] = parser.ReadOffset< string >( 0x28 );
            ScriptInstruction[6] = parser.ReadOffset< string >( 0x30 );
            ScriptInstruction[7] = parser.ReadOffset< string >( 0x38 );
            ScriptInstruction[8] = parser.ReadOffset< string >( 0x40 );
            ScriptInstruction[9] = parser.ReadOffset< string >( 0x48 );
            ScriptInstruction[10] = parser.ReadOffset< string >( 0x50 );
            ScriptInstruction[11] = parser.ReadOffset< string >( 0x58 );
            ScriptInstruction[12] = parser.ReadOffset< string >( 0x60 );
            ScriptInstruction[13] = parser.ReadOffset< string >( 0x68 );
            ScriptInstruction[14] = parser.ReadOffset< string >( 0x70 );
            ScriptInstruction[15] = parser.ReadOffset< string >( 0x78 );
            ScriptInstruction[16] = parser.ReadOffset< string >( 0x80 );
            ScriptInstruction[17] = parser.ReadOffset< string >( 0x88 );
            ScriptInstruction[18] = parser.ReadOffset< string >( 0x90 );
            ScriptInstruction[19] = parser.ReadOffset< string >( 0x98 );
            ScriptInstruction[20] = parser.ReadOffset< string >( 0xa0 );
            ScriptInstruction[21] = parser.ReadOffset< string >( 0xa8 );
            ScriptInstruction[22] = parser.ReadOffset< string >( 0xb0 );
            ScriptInstruction[23] = parser.ReadOffset< string >( 0xb8 );
            ScriptInstruction[24] = parser.ReadOffset< string >( 0xc0 );
            ScriptInstruction[25] = parser.ReadOffset< string >( 0xc8 );
            ScriptInstruction[26] = parser.ReadOffset< string >( 0xd0 );
            ScriptInstruction[27] = parser.ReadOffset< string >( 0xd8 );
            ScriptInstruction[28] = parser.ReadOffset< string >( 0xe0 );
            ScriptInstruction[29] = parser.ReadOffset< string >( 0xe8 );
            ScriptInstruction[30] = parser.ReadOffset< string >( 0xf0 );
            ScriptInstruction[31] = parser.ReadOffset< string >( 0xf8 );
            ScriptInstruction[32] = parser.ReadOffset< string >( 0x100 );
            ScriptInstruction[33] = parser.ReadOffset< string >( 0x108 );
            ScriptInstruction[34] = parser.ReadOffset< string >( 0x110 );
            ScriptInstruction[35] = parser.ReadOffset< string >( 0x118 );
            ScriptInstruction[36] = parser.ReadOffset< string >( 0x120 );
            ScriptInstruction[37] = parser.ReadOffset< string >( 0x128 );
            ScriptInstruction[38] = parser.ReadOffset< string >( 0x130 );
            ScriptInstruction[39] = parser.ReadOffset< string >( 0x138 );
            ScriptInstruction[40] = parser.ReadOffset< string >( 0x140 );
            ScriptInstruction[41] = parser.ReadOffset< string >( 0x148 );
            ScriptInstruction[42] = parser.ReadOffset< string >( 0x150 );
            ScriptInstruction[43] = parser.ReadOffset< string >( 0x158 );
            ScriptInstruction[44] = parser.ReadOffset< string >( 0x160 );
            ScriptInstruction[45] = parser.ReadOffset< string >( 0x168 );
            ScriptInstruction[46] = parser.ReadOffset< string >( 0x170 );
            ScriptInstruction[47] = parser.ReadOffset< string >( 0x178 );
            ScriptInstruction[48] = parser.ReadOffset< string >( 0x180 );
            ScriptInstruction[49] = parser.ReadOffset< string >( 0x188 );
            ScriptInstruction[50] = parser.ReadOffset< string >( 0x190 );
            ScriptInstruction[51] = parser.ReadOffset< string >( 0x198 );
            ScriptInstruction[52] = parser.ReadOffset< string >( 0x1a0 );
            ScriptInstruction[53] = parser.ReadOffset< string >( 0x1a8 );
            ScriptInstruction[54] = parser.ReadOffset< string >( 0x1b0 );
            ScriptInstruction[55] = parser.ReadOffset< string >( 0x1b8 );
            ScriptInstruction[56] = parser.ReadOffset< string >( 0x1c0 );
            ScriptInstruction[57] = parser.ReadOffset< string >( 0x1c8 );
            ScriptInstruction[58] = parser.ReadOffset< string >( 0x1d0 );
            ScriptInstruction[59] = parser.ReadOffset< string >( 0x1d8 );
            ScriptInstruction[60] = parser.ReadOffset< string >( 0x1e0 );
            ScriptInstruction[61] = parser.ReadOffset< string >( 0x1e8 );
            ScriptInstruction[62] = parser.ReadOffset< string >( 0x1f0 );
            ScriptInstruction[63] = parser.ReadOffset< string >( 0x1f8 );
            ScriptInstruction[64] = parser.ReadOffset< string >( 0x200 );
            ScriptInstruction[65] = parser.ReadOffset< string >( 0x208 );
            ScriptInstruction[66] = parser.ReadOffset< string >( 0x210 );
            ScriptInstruction[67] = parser.ReadOffset< string >( 0x218 );
            ScriptInstruction[68] = parser.ReadOffset< string >( 0x220 );
            ScriptInstruction[69] = parser.ReadOffset< string >( 0x228 );
            ScriptInstruction[70] = parser.ReadOffset< string >( 0x230 );
            ScriptInstruction[71] = parser.ReadOffset< string >( 0x238 );
            ScriptInstruction[72] = parser.ReadOffset< string >( 0x240 );
            ScriptInstruction[73] = parser.ReadOffset< string >( 0x248 );
            ScriptInstruction[74] = parser.ReadOffset< string >( 0x250 );
            ScriptInstruction[75] = parser.ReadOffset< string >( 0x258 );
            ScriptInstruction[76] = parser.ReadOffset< string >( 0x260 );
            ScriptInstruction[77] = parser.ReadOffset< string >( 0x268 );
            ScriptInstruction[78] = parser.ReadOffset< string >( 0x270 );
            ScriptInstruction[79] = parser.ReadOffset< string >( 0x278 );
            ScriptInstruction[80] = parser.ReadOffset< string >( 0x280 );
            ScriptInstruction[81] = parser.ReadOffset< string >( 0x288 );
            ScriptInstruction[82] = parser.ReadOffset< string >( 0x290 );
            ScriptInstruction[83] = parser.ReadOffset< string >( 0x298 );
            ScriptInstruction[84] = parser.ReadOffset< string >( 0x2a0 );
            ScriptInstruction[85] = parser.ReadOffset< string >( 0x2a8 );
            ScriptInstruction[86] = parser.ReadOffset< string >( 0x2b0 );
            ScriptInstruction[87] = parser.ReadOffset< string >( 0x2b8 );
            ScriptInstruction[88] = parser.ReadOffset< string >( 0x2c0 );
            ScriptInstruction[89] = parser.ReadOffset< string >( 0x2c8 );
            ScriptInstruction[90] = parser.ReadOffset< string >( 0x2d0 );
            ScriptInstruction[91] = parser.ReadOffset< string >( 0x2d8 );
            ScriptInstruction[92] = parser.ReadOffset< string >( 0x2e0 );
            ScriptInstruction[93] = parser.ReadOffset< string >( 0x2e8 );
            ScriptInstruction[94] = parser.ReadOffset< string >( 0x2f0 );
            ScriptInstruction[95] = parser.ReadOffset< string >( 0x2f8 );
            ScriptInstruction[96] = parser.ReadOffset< string >( 0x300 );
            ScriptInstruction[97] = parser.ReadOffset< string >( 0x308 );
            ScriptInstruction[98] = parser.ReadOffset< string >( 0x310 );
            ScriptInstruction[99] = parser.ReadOffset< string >( 0x318 );
            ScriptInstruction[100] = parser.ReadOffset< string >( 0x320 );
            ScriptInstruction[101] = parser.ReadOffset< string >( 0x328 );
            ScriptInstruction[102] = parser.ReadOffset< string >( 0x330 );
            ScriptInstruction[103] = parser.ReadOffset< string >( 0x338 );
            ScriptInstruction[104] = parser.ReadOffset< string >( 0x340 );
            ScriptInstruction[105] = parser.ReadOffset< string >( 0x348 );
            ScriptInstruction[106] = parser.ReadOffset< string >( 0x350 );
            ScriptInstruction[107] = parser.ReadOffset< string >( 0x358 );
            ScriptInstruction[108] = parser.ReadOffset< string >( 0x360 );
            ScriptInstruction[109] = parser.ReadOffset< string >( 0x368 );
            ScriptInstruction[110] = parser.ReadOffset< string >( 0x370 );
            ScriptInstruction[111] = parser.ReadOffset< string >( 0x378 );
            ScriptInstruction[112] = parser.ReadOffset< string >( 0x380 );
            ScriptInstruction[113] = parser.ReadOffset< string >( 0x388 );
            ScriptInstruction[114] = parser.ReadOffset< string >( 0x390 );
            ScriptInstruction[115] = parser.ReadOffset< string >( 0x398 );
            ScriptInstruction[116] = parser.ReadOffset< string >( 0x3a0 );
            ScriptInstruction[117] = parser.ReadOffset< string >( 0x3a8 );
            ScriptInstruction[118] = parser.ReadOffset< string >( 0x3b0 );
            ScriptInstruction[119] = parser.ReadOffset< string >( 0x3b8 );
            ScriptInstruction[120] = parser.ReadOffset< string >( 0x3c0 );
            ScriptInstruction[121] = parser.ReadOffset< string >( 0x3c8 );
            ScriptInstruction[122] = parser.ReadOffset< string >( 0x3d0 );
            ScriptInstruction[123] = parser.ReadOffset< string >( 0x3d8 );
            ScriptInstruction[124] = parser.ReadOffset< string >( 0x3e0 );
            ScriptInstruction[125] = parser.ReadOffset< string >( 0x3e8 );
            ScriptInstruction[126] = parser.ReadOffset< string >( 0x3f0 );
            ScriptInstruction[127] = parser.ReadOffset< string >( 0x3f8 );
            ScriptInstruction[128] = parser.ReadOffset< string >( 0x400 );
            ScriptInstruction[129] = parser.ReadOffset< string >( 0x408 );
            ScriptInstruction[130] = parser.ReadOffset< string >( 0x410 );
            ScriptInstruction[131] = parser.ReadOffset< string >( 0x418 );
            ScriptInstruction[132] = parser.ReadOffset< string >( 0x420 );
            ScriptInstruction[133] = parser.ReadOffset< string >( 0x428 );
            ScriptInstruction[134] = parser.ReadOffset< string >( 0x430 );
            ScriptInstruction[135] = parser.ReadOffset< string >( 0x438 );
            ScriptInstruction[136] = parser.ReadOffset< string >( 0x440 );
            ScriptInstruction[137] = parser.ReadOffset< string >( 0x448 );
            ScriptInstruction[138] = parser.ReadOffset< string >( 0x450 );
            ScriptInstruction[139] = parser.ReadOffset< string >( 0x458 );
            ScriptInstruction[140] = parser.ReadOffset< string >( 0x460 );
            ScriptInstruction[141] = parser.ReadOffset< string >( 0x468 );
            ScriptInstruction[142] = parser.ReadOffset< string >( 0x470 );
            ScriptInstruction[143] = parser.ReadOffset< string >( 0x478 );
            ScriptInstruction[144] = parser.ReadOffset< string >( 0x480 );
            ScriptInstruction[145] = parser.ReadOffset< string >( 0x488 );
            ScriptInstruction[146] = parser.ReadOffset< string >( 0x490 );
            ScriptInstruction[147] = parser.ReadOffset< string >( 0x498 );
            ScriptInstruction[148] = parser.ReadOffset< string >( 0x4a0 );
            ScriptInstruction[149] = parser.ReadOffset< string >( 0x4a8 );
            ScriptInstruction[150] = parser.ReadOffset< string >( 0x4b0 );
            ScriptInstruction[151] = parser.ReadOffset< string >( 0x4b8 );
            ScriptInstruction[152] = parser.ReadOffset< string >( 0x4c0 );
            ScriptInstruction[153] = parser.ReadOffset< string >( 0x4c8 );
            ScriptInstruction[154] = parser.ReadOffset< string >( 0x4d0 );
            ScriptInstruction[155] = parser.ReadOffset< string >( 0x4d8 );
            ScriptInstruction[156] = parser.ReadOffset< string >( 0x4e0 );
            ScriptInstruction[157] = parser.ReadOffset< string >( 0x4e8 );
            ScriptInstruction[158] = parser.ReadOffset< string >( 0x4f0 );
            ScriptInstruction[159] = parser.ReadOffset< string >( 0x4f8 );
            ScriptInstruction[160] = parser.ReadOffset< string >( 0x500 );
            ScriptInstruction[161] = parser.ReadOffset< string >( 0x508 );
            ScriptInstruction[162] = parser.ReadOffset< string >( 0x510 );
            ScriptInstruction[163] = parser.ReadOffset< string >( 0x518 );
            ScriptInstruction[164] = parser.ReadOffset< string >( 0x520 );
            ScriptInstruction[165] = parser.ReadOffset< string >( 0x528 );
            ScriptInstruction[166] = parser.ReadOffset< string >( 0x530 );
            ScriptInstruction[167] = parser.ReadOffset< string >( 0x538 );
            ScriptInstruction[168] = parser.ReadOffset< string >( 0x540 );
            ScriptInstruction[169] = parser.ReadOffset< string >( 0x548 );
            ScriptInstruction[170] = parser.ReadOffset< string >( 0x550 );
            ScriptInstruction[171] = parser.ReadOffset< string >( 0x558 );
            ScriptInstruction[172] = parser.ReadOffset< string >( 0x560 );
            ScriptInstruction[173] = parser.ReadOffset< string >( 0x568 );
            ScriptInstruction[174] = parser.ReadOffset< string >( 0x570 );
            ScriptInstruction[175] = parser.ReadOffset< string >( 0x578 );
            ScriptInstruction[176] = parser.ReadOffset< string >( 0x580 );
            ScriptInstruction[177] = parser.ReadOffset< string >( 0x588 );
            ScriptInstruction[178] = parser.ReadOffset< string >( 0x590 );
            ScriptInstruction[179] = parser.ReadOffset< string >( 0x598 );
            ScriptInstruction[180] = parser.ReadOffset< string >( 0x5a0 );
            ScriptInstruction[181] = parser.ReadOffset< string >( 0x5a8 );
            ScriptInstruction[182] = parser.ReadOffset< string >( 0x5b0 );
            ScriptInstruction[183] = parser.ReadOffset< string >( 0x5b8 );
            ScriptInstruction[184] = parser.ReadOffset< string >( 0x5c0 );
            ScriptInstruction[185] = parser.ReadOffset< string >( 0x5c8 );
            ScriptInstruction[186] = parser.ReadOffset< string >( 0x5d0 );
            ScriptInstruction[187] = parser.ReadOffset< string >( 0x5d8 );
            ScriptInstruction[188] = parser.ReadOffset< string >( 0x5e0 );
            ScriptInstruction[189] = parser.ReadOffset< string >( 0x5e8 );
            ScriptInstruction[190] = parser.ReadOffset< string >( 0x5f0 );
            ScriptInstruction[191] = parser.ReadOffset< string >( 0x5f8 );
            ScriptInstruction[192] = parser.ReadOffset< string >( 0x600 );
            ScriptInstruction[193] = parser.ReadOffset< string >( 0x608 );
            ScriptInstruction[194] = parser.ReadOffset< string >( 0x610 );
            ScriptInstruction[195] = parser.ReadOffset< string >( 0x618 );
            ScriptInstruction[196] = parser.ReadOffset< string >( 0x620 );
            ScriptInstruction[197] = parser.ReadOffset< string >( 0x628 );
            ScriptInstruction[198] = parser.ReadOffset< string >( 0x630 );
            ScriptInstruction[199] = parser.ReadOffset< string >( 0x638 );

            // col: 204 offset: 0004
            ScriptValue = new uint[200];
            ScriptValue[0] = parser.ReadOffset< uint >( 0x4 );
            ScriptValue[1] = parser.ReadOffset< uint >( 0xc );
            ScriptValue[2] = parser.ReadOffset< uint >( 0x14 );
            ScriptValue[3] = parser.ReadOffset< uint >( 0x1c );
            ScriptValue[4] = parser.ReadOffset< uint >( 0x24 );
            ScriptValue[5] = parser.ReadOffset< uint >( 0x2c );
            ScriptValue[6] = parser.ReadOffset< uint >( 0x34 );
            ScriptValue[7] = parser.ReadOffset< uint >( 0x3c );
            ScriptValue[8] = parser.ReadOffset< uint >( 0x44 );
            ScriptValue[9] = parser.ReadOffset< uint >( 0x4c );
            ScriptValue[10] = parser.ReadOffset< uint >( 0x54 );
            ScriptValue[11] = parser.ReadOffset< uint >( 0x5c );
            ScriptValue[12] = parser.ReadOffset< uint >( 0x64 );
            ScriptValue[13] = parser.ReadOffset< uint >( 0x6c );
            ScriptValue[14] = parser.ReadOffset< uint >( 0x74 );
            ScriptValue[15] = parser.ReadOffset< uint >( 0x7c );
            ScriptValue[16] = parser.ReadOffset< uint >( 0x84 );
            ScriptValue[17] = parser.ReadOffset< uint >( 0x8c );
            ScriptValue[18] = parser.ReadOffset< uint >( 0x94 );
            ScriptValue[19] = parser.ReadOffset< uint >( 0x9c );
            ScriptValue[20] = parser.ReadOffset< uint >( 0xa4 );
            ScriptValue[21] = parser.ReadOffset< uint >( 0xac );
            ScriptValue[22] = parser.ReadOffset< uint >( 0xb4 );
            ScriptValue[23] = parser.ReadOffset< uint >( 0xbc );
            ScriptValue[24] = parser.ReadOffset< uint >( 0xc4 );
            ScriptValue[25] = parser.ReadOffset< uint >( 0xcc );
            ScriptValue[26] = parser.ReadOffset< uint >( 0xd4 );
            ScriptValue[27] = parser.ReadOffset< uint >( 0xdc );
            ScriptValue[28] = parser.ReadOffset< uint >( 0xe4 );
            ScriptValue[29] = parser.ReadOffset< uint >( 0xec );
            ScriptValue[30] = parser.ReadOffset< uint >( 0xf4 );
            ScriptValue[31] = parser.ReadOffset< uint >( 0xfc );
            ScriptValue[32] = parser.ReadOffset< uint >( 0x104 );
            ScriptValue[33] = parser.ReadOffset< uint >( 0x10c );
            ScriptValue[34] = parser.ReadOffset< uint >( 0x114 );
            ScriptValue[35] = parser.ReadOffset< uint >( 0x11c );
            ScriptValue[36] = parser.ReadOffset< uint >( 0x124 );
            ScriptValue[37] = parser.ReadOffset< uint >( 0x12c );
            ScriptValue[38] = parser.ReadOffset< uint >( 0x134 );
            ScriptValue[39] = parser.ReadOffset< uint >( 0x13c );
            ScriptValue[40] = parser.ReadOffset< uint >( 0x144 );
            ScriptValue[41] = parser.ReadOffset< uint >( 0x14c );
            ScriptValue[42] = parser.ReadOffset< uint >( 0x154 );
            ScriptValue[43] = parser.ReadOffset< uint >( 0x15c );
            ScriptValue[44] = parser.ReadOffset< uint >( 0x164 );
            ScriptValue[45] = parser.ReadOffset< uint >( 0x16c );
            ScriptValue[46] = parser.ReadOffset< uint >( 0x174 );
            ScriptValue[47] = parser.ReadOffset< uint >( 0x17c );
            ScriptValue[48] = parser.ReadOffset< uint >( 0x184 );
            ScriptValue[49] = parser.ReadOffset< uint >( 0x18c );
            ScriptValue[50] = parser.ReadOffset< uint >( 0x194 );
            ScriptValue[51] = parser.ReadOffset< uint >( 0x19c );
            ScriptValue[52] = parser.ReadOffset< uint >( 0x1a4 );
            ScriptValue[53] = parser.ReadOffset< uint >( 0x1ac );
            ScriptValue[54] = parser.ReadOffset< uint >( 0x1b4 );
            ScriptValue[55] = parser.ReadOffset< uint >( 0x1bc );
            ScriptValue[56] = parser.ReadOffset< uint >( 0x1c4 );
            ScriptValue[57] = parser.ReadOffset< uint >( 0x1cc );
            ScriptValue[58] = parser.ReadOffset< uint >( 0x1d4 );
            ScriptValue[59] = parser.ReadOffset< uint >( 0x1dc );
            ScriptValue[60] = parser.ReadOffset< uint >( 0x1e4 );
            ScriptValue[61] = parser.ReadOffset< uint >( 0x1ec );
            ScriptValue[62] = parser.ReadOffset< uint >( 0x1f4 );
            ScriptValue[63] = parser.ReadOffset< uint >( 0x1fc );
            ScriptValue[64] = parser.ReadOffset< uint >( 0x204 );
            ScriptValue[65] = parser.ReadOffset< uint >( 0x20c );
            ScriptValue[66] = parser.ReadOffset< uint >( 0x214 );
            ScriptValue[67] = parser.ReadOffset< uint >( 0x21c );
            ScriptValue[68] = parser.ReadOffset< uint >( 0x224 );
            ScriptValue[69] = parser.ReadOffset< uint >( 0x22c );
            ScriptValue[70] = parser.ReadOffset< uint >( 0x234 );
            ScriptValue[71] = parser.ReadOffset< uint >( 0x23c );
            ScriptValue[72] = parser.ReadOffset< uint >( 0x244 );
            ScriptValue[73] = parser.ReadOffset< uint >( 0x24c );
            ScriptValue[74] = parser.ReadOffset< uint >( 0x254 );
            ScriptValue[75] = parser.ReadOffset< uint >( 0x25c );
            ScriptValue[76] = parser.ReadOffset< uint >( 0x264 );
            ScriptValue[77] = parser.ReadOffset< uint >( 0x26c );
            ScriptValue[78] = parser.ReadOffset< uint >( 0x274 );
            ScriptValue[79] = parser.ReadOffset< uint >( 0x27c );
            ScriptValue[80] = parser.ReadOffset< uint >( 0x284 );
            ScriptValue[81] = parser.ReadOffset< uint >( 0x28c );
            ScriptValue[82] = parser.ReadOffset< uint >( 0x294 );
            ScriptValue[83] = parser.ReadOffset< uint >( 0x29c );
            ScriptValue[84] = parser.ReadOffset< uint >( 0x2a4 );
            ScriptValue[85] = parser.ReadOffset< uint >( 0x2ac );
            ScriptValue[86] = parser.ReadOffset< uint >( 0x2b4 );
            ScriptValue[87] = parser.ReadOffset< uint >( 0x2bc );
            ScriptValue[88] = parser.ReadOffset< uint >( 0x2c4 );
            ScriptValue[89] = parser.ReadOffset< uint >( 0x2cc );
            ScriptValue[90] = parser.ReadOffset< uint >( 0x2d4 );
            ScriptValue[91] = parser.ReadOffset< uint >( 0x2dc );
            ScriptValue[92] = parser.ReadOffset< uint >( 0x2e4 );
            ScriptValue[93] = parser.ReadOffset< uint >( 0x2ec );
            ScriptValue[94] = parser.ReadOffset< uint >( 0x2f4 );
            ScriptValue[95] = parser.ReadOffset< uint >( 0x2fc );
            ScriptValue[96] = parser.ReadOffset< uint >( 0x304 );
            ScriptValue[97] = parser.ReadOffset< uint >( 0x30c );
            ScriptValue[98] = parser.ReadOffset< uint >( 0x314 );
            ScriptValue[99] = parser.ReadOffset< uint >( 0x31c );
            ScriptValue[100] = parser.ReadOffset< uint >( 0x324 );
            ScriptValue[101] = parser.ReadOffset< uint >( 0x32c );
            ScriptValue[102] = parser.ReadOffset< uint >( 0x334 );
            ScriptValue[103] = parser.ReadOffset< uint >( 0x33c );
            ScriptValue[104] = parser.ReadOffset< uint >( 0x344 );
            ScriptValue[105] = parser.ReadOffset< uint >( 0x34c );
            ScriptValue[106] = parser.ReadOffset< uint >( 0x354 );
            ScriptValue[107] = parser.ReadOffset< uint >( 0x35c );
            ScriptValue[108] = parser.ReadOffset< uint >( 0x364 );
            ScriptValue[109] = parser.ReadOffset< uint >( 0x36c );
            ScriptValue[110] = parser.ReadOffset< uint >( 0x374 );
            ScriptValue[111] = parser.ReadOffset< uint >( 0x37c );
            ScriptValue[112] = parser.ReadOffset< uint >( 0x384 );
            ScriptValue[113] = parser.ReadOffset< uint >( 0x38c );
            ScriptValue[114] = parser.ReadOffset< uint >( 0x394 );
            ScriptValue[115] = parser.ReadOffset< uint >( 0x39c );
            ScriptValue[116] = parser.ReadOffset< uint >( 0x3a4 );
            ScriptValue[117] = parser.ReadOffset< uint >( 0x3ac );
            ScriptValue[118] = parser.ReadOffset< uint >( 0x3b4 );
            ScriptValue[119] = parser.ReadOffset< uint >( 0x3bc );
            ScriptValue[120] = parser.ReadOffset< uint >( 0x3c4 );
            ScriptValue[121] = parser.ReadOffset< uint >( 0x3cc );
            ScriptValue[122] = parser.ReadOffset< uint >( 0x3d4 );
            ScriptValue[123] = parser.ReadOffset< uint >( 0x3dc );
            ScriptValue[124] = parser.ReadOffset< uint >( 0x3e4 );
            ScriptValue[125] = parser.ReadOffset< uint >( 0x3ec );
            ScriptValue[126] = parser.ReadOffset< uint >( 0x3f4 );
            ScriptValue[127] = parser.ReadOffset< uint >( 0x3fc );
            ScriptValue[128] = parser.ReadOffset< uint >( 0x404 );
            ScriptValue[129] = parser.ReadOffset< uint >( 0x40c );
            ScriptValue[130] = parser.ReadOffset< uint >( 0x414 );
            ScriptValue[131] = parser.ReadOffset< uint >( 0x41c );
            ScriptValue[132] = parser.ReadOffset< uint >( 0x424 );
            ScriptValue[133] = parser.ReadOffset< uint >( 0x42c );
            ScriptValue[134] = parser.ReadOffset< uint >( 0x434 );
            ScriptValue[135] = parser.ReadOffset< uint >( 0x43c );
            ScriptValue[136] = parser.ReadOffset< uint >( 0x444 );
            ScriptValue[137] = parser.ReadOffset< uint >( 0x44c );
            ScriptValue[138] = parser.ReadOffset< uint >( 0x454 );
            ScriptValue[139] = parser.ReadOffset< uint >( 0x45c );
            ScriptValue[140] = parser.ReadOffset< uint >( 0x464 );
            ScriptValue[141] = parser.ReadOffset< uint >( 0x46c );
            ScriptValue[142] = parser.ReadOffset< uint >( 0x474 );
            ScriptValue[143] = parser.ReadOffset< uint >( 0x47c );
            ScriptValue[144] = parser.ReadOffset< uint >( 0x484 );
            ScriptValue[145] = parser.ReadOffset< uint >( 0x48c );
            ScriptValue[146] = parser.ReadOffset< uint >( 0x494 );
            ScriptValue[147] = parser.ReadOffset< uint >( 0x49c );
            ScriptValue[148] = parser.ReadOffset< uint >( 0x4a4 );
            ScriptValue[149] = parser.ReadOffset< uint >( 0x4ac );
            ScriptValue[150] = parser.ReadOffset< uint >( 0x4b4 );
            ScriptValue[151] = parser.ReadOffset< uint >( 0x4bc );
            ScriptValue[152] = parser.ReadOffset< uint >( 0x4c4 );
            ScriptValue[153] = parser.ReadOffset< uint >( 0x4cc );
            ScriptValue[154] = parser.ReadOffset< uint >( 0x4d4 );
            ScriptValue[155] = parser.ReadOffset< uint >( 0x4dc );
            ScriptValue[156] = parser.ReadOffset< uint >( 0x4e4 );
            ScriptValue[157] = parser.ReadOffset< uint >( 0x4ec );
            ScriptValue[158] = parser.ReadOffset< uint >( 0x4f4 );
            ScriptValue[159] = parser.ReadOffset< uint >( 0x4fc );
            ScriptValue[160] = parser.ReadOffset< uint >( 0x504 );
            ScriptValue[161] = parser.ReadOffset< uint >( 0x50c );
            ScriptValue[162] = parser.ReadOffset< uint >( 0x514 );
            ScriptValue[163] = parser.ReadOffset< uint >( 0x51c );
            ScriptValue[164] = parser.ReadOffset< uint >( 0x524 );
            ScriptValue[165] = parser.ReadOffset< uint >( 0x52c );
            ScriptValue[166] = parser.ReadOffset< uint >( 0x534 );
            ScriptValue[167] = parser.ReadOffset< uint >( 0x53c );
            ScriptValue[168] = parser.ReadOffset< uint >( 0x544 );
            ScriptValue[169] = parser.ReadOffset< uint >( 0x54c );
            ScriptValue[170] = parser.ReadOffset< uint >( 0x554 );
            ScriptValue[171] = parser.ReadOffset< uint >( 0x55c );
            ScriptValue[172] = parser.ReadOffset< uint >( 0x564 );
            ScriptValue[173] = parser.ReadOffset< uint >( 0x56c );
            ScriptValue[174] = parser.ReadOffset< uint >( 0x574 );
            ScriptValue[175] = parser.ReadOffset< uint >( 0x57c );
            ScriptValue[176] = parser.ReadOffset< uint >( 0x584 );
            ScriptValue[177] = parser.ReadOffset< uint >( 0x58c );
            ScriptValue[178] = parser.ReadOffset< uint >( 0x594 );
            ScriptValue[179] = parser.ReadOffset< uint >( 0x59c );
            ScriptValue[180] = parser.ReadOffset< uint >( 0x5a4 );
            ScriptValue[181] = parser.ReadOffset< uint >( 0x5ac );
            ScriptValue[182] = parser.ReadOffset< uint >( 0x5b4 );
            ScriptValue[183] = parser.ReadOffset< uint >( 0x5bc );
            ScriptValue[184] = parser.ReadOffset< uint >( 0x5c4 );
            ScriptValue[185] = parser.ReadOffset< uint >( 0x5cc );
            ScriptValue[186] = parser.ReadOffset< uint >( 0x5d4 );
            ScriptValue[187] = parser.ReadOffset< uint >( 0x5dc );
            ScriptValue[188] = parser.ReadOffset< uint >( 0x5e4 );
            ScriptValue[189] = parser.ReadOffset< uint >( 0x5ec );
            ScriptValue[190] = parser.ReadOffset< uint >( 0x5f4 );
            ScriptValue[191] = parser.ReadOffset< uint >( 0x5fc );
            ScriptValue[192] = parser.ReadOffset< uint >( 0x604 );
            ScriptValue[193] = parser.ReadOffset< uint >( 0x60c );
            ScriptValue[194] = parser.ReadOffset< uint >( 0x614 );
            ScriptValue[195] = parser.ReadOffset< uint >( 0x61c );
            ScriptValue[196] = parser.ReadOffset< uint >( 0x624 );
            ScriptValue[197] = parser.ReadOffset< uint >( 0x62c );
            ScriptValue[198] = parser.ReadOffset< uint >( 0x634 );
            ScriptValue[199] = parser.ReadOffset< uint >( 0x63c );

            // col: 0 offset: 0640
            Quest = parser.ReadOffset< int >( 0x640 );

            // col: 2 offset: 0644
            TimeLimit = parser.ReadOffset< ushort >( 0x644 );

            // col: 3 offset: 0646
            LevelSync = parser.ReadOffset< ushort >( 0x646 );

            // col: 1 offset: 0648
            QuestBattleScene = parser.ReadOffset< byte >( 0x648 );


        }
    }
}