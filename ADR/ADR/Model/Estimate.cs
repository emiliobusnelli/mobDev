using System;
using ADR.Model;
using SQLite;
using ADR.Views;

namespace ADR.Model
{
    public class Estimate
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string DateEstimated { get; set; }

        public string DeckSqFt { get; set; }
        public string DeckCost { get; set; }
        //public decimal decDeck { get; set; }
        public string DeckTotalCost { get; set; }

        //[MaxLength(250)]
        public string SpindalLiFt { get; set; }
        public string SpindalCost { get; set; }
        //public decimal decSpindal { get; set; }
        public string SpindalTotalCost { get; set; }

        public string RailLiFt { get; set; }
        public string RailCost { get; set; }
        //public decimal decRail { get; set; }
        public string RailTotalCost { get; set; }

        public string FascaLiFt { get; set; }
        public string FascaCost { get; set; }
       //public decimal decFasca { get; set; }
        public string FascaTotalCost { get; set; }

        public string SkirtingLiFt { get; set; }
        public string SkirtingCost { get; set; }
        //public decimal decSkirting { get; set; }
        public string SkirtingTotalCost { get; set; }

        public string StepNum { get; set; }
        public string StepCost { get; set; }
        //public decimal decStep { get; set; }
        public string StepTotalCost { get; set; }

        public string PostNum { get; set; }
        public string PostCost { get; set; }
        //public decimal decPost { get; set; }
        public string PostTotalCost { get; set; }

        public string BeamType { get; set; }
        public string BeamCost { get; set; }
        //public decimal decBeam { get; set; }
        public string BeamTotalCost { get; set; }

        public string EstimateTotalCost { get; set; }

        public string GetTotalCost()
        {

            if (!decimal.TryParse(DeckTotalCost, out decimal decDeck))
            {

                App.est.DeckSqFt = null;
                App.est.DeckCost = null;
                App.est.DeckTotalCost = null;
                decDeck = 0;
                //throw new Exception("Invalid Deck Cost");


            }

            if (!decimal.TryParse(SpindalTotalCost, out decimal decSpindal))
            {
                App.est.SpindalLiFt = null;
                App.est.SpindalCost = null;
                App.est.SpindalTotalCost = null;
                decSpindal = 0;
                //throw new Exception("Invalid Spindal Cost");
            }




            if (!decimal.TryParse(RailTotalCost, out decimal decRail))
            {
                App.est.RailLiFt = null;
                App.est.RailCost = null;
                App.est.RailTotalCost = null;
                decRail = 0;
                //throw new Exception("Invalid Rail Cost");
            }



            if (!decimal.TryParse(FascaTotalCost, out decimal decFasca))
            {
                App.est.FascaLiFt = null;
                App.est.FascaCost = null;
                App.est.FascaTotalCost = null;
                decFasca = 0;
                //throw new Exception("Invalid Fasca Cost");
            }




            if (!decimal.TryParse(SkirtingTotalCost, out decimal decSkirting))
            {
                App.est.SkirtingLiFt = null;
                App.est.SkirtingCost = null;
                App.est.SkirtingTotalCost = null;
                decSkirting = 0;
                //throw new Exception("Invalid Skirting Cost");
            }



            if (!decimal.TryParse(StepTotalCost, out decimal decStep))
            {
                App.est.StepNum = null;
                App.est.StepCost = null;
                App.est.StepTotalCost = null;
                decStep = 0;
                //throw new Exception("Invalid Step Cost");
            }




            if (!decimal.TryParse(PostTotalCost, out decimal decPost))
            {
                App.est.PostNum = null;
                App.est.PostCost = null;
                App.est.PostTotalCost = null;
                decPost = 0;
                //throw new Exception("Invalid Post Cost");
            }



            if (!decimal.TryParse(BeamTotalCost, out decimal decBeam))
            {
                App.est.BeamType = null;
                App.est.BeamCost = null;
                App.est.BeamTotalCost = null;
                decBeam = 0;
                //throw new Exception("Invalid Beam Cost");
            }

            return EstimateTotalCost = (decDeck + decSpindal + decRail + decFasca + decSkirting + decStep + decPost + decBeam).ToString("C");
        }



        


    }
}
