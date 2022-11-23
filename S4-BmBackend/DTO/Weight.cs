namespace S4_BmBackend.DTO
{
    public class Weight
    {
        public Weight(int bones, int muscle, int fat, int fatPercentage, int mass, int bMR, int fluid, int fluidPercentage)
        {
            Bones = bones;
            Muscle = muscle;
            Fat = fat;
            FatPercentage = fatPercentage;
            Mass = mass;
            BMR = bMR;
            Fluid = fluid;
            FluidPercentage = fluidPercentage;
        }

        public int Bones { get; private set; }
        public int Muscle { get; private set; }
        public int Fat { get; private set; }
        public int FatPercentage {get; private set; }
        public int Mass { get; private set; }
        public int BMR { get; private set; }
        public int Fluid { get; private set; }
        public int FluidPercentage {get; private set; }
    }
}
