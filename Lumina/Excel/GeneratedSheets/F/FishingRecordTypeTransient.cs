using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "FishingRecordTypeTransient", columnHash: 0xda365c51 )]
    public class FishingRecordTypeTransient : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public int Image;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Image = parser.ReadOffset< int >( 0x0 );


        }
    }
}