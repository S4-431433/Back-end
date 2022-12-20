namespace S4_BmBackend.DTO
{
    public class GoalDTO
    {
        public GoalDTO()
        {
        }

        public GoalDTO(int id, double bones, double muscle, double fat, double fatPercentage, double mass, double bMR, double fluid, double fluidPercentage)
        {
            Id= id;
            Bones = bones;
            Muscle = muscle;
            Fat = fat;
            FatPercentage = fatPercentage;
            Mass = mass;
            BMR = bMR;
            Fluid = fluid;
            FluidPercentage = fluidPercentage;
        }

        public int Id { get;  set; }
        public double Bones { get;  set; }
        public double Muscle { get;  set; }
        public double Fat { get;  set; }
        public double FatPercentage { get; set; }
        public double Mass { get; set; }
        public double BMR { get; set; }
        public double Fluid { get; set; }
        public double FluidPercentage { get; set; }
    }
}
