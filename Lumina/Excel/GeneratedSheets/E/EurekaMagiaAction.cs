using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "EurekaMagiaAction", columnHash: 0x5a516458 )]
    public class EurekaMagiaAction : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public uint Action;

        // col: 01 offset: 0004
        public byte MaxUses;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Action = parser.ReadOffset< uint >( 0x0 );

            // col: 1 offset: 0004
            MaxUses = parser.ReadOffset< byte >( 0x4 );


        }
    }
}