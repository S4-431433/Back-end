namespace S4_BmBackend.DTO
{
    public class Test
    {
        public int Id { get; set; }

        public double ImpactForce { get; set; }

        public double ImpactDirectionX { get; set; }

        public double ImpactDirectionY { get; set; }

        public double ImpactDirectionZ { get; set; }

        public Test(int id, double impactForce, double impactDirectionX, double impactDirectionY, double impactDirectionZ)
        {
            Id = id;
            ImpactForce = impactForce;
            ImpactDirectionX = impactDirectionX;
            ImpactDirectionY = impactDirectionY;
            ImpactDirectionZ = impactDirectionZ;
        }

    }
}
