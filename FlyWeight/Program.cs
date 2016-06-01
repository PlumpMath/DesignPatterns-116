namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyWeightFactory flyWeightFactory = new FlyWeightFactory();

            FlyWeight flyWeightX = flyWeightFactory.GetFlyWeight("X");
            flyWeightX.Operation(--extrinsicstate);

            FlyWeight flyWeightY = flyWeightFactory.GetFlyWeight("Y");
            flyWeightY.Operation(--extrinsicstate);

            FlyWeight flyWeightZ = flyWeightFactory.GetFlyWeight("Z");
            flyWeightZ.Operation(--extrinsicstate);

            FlyWeight uf = new UnsharedConcreteFlyWeight();
            uf.Operation(--extrinsicstate);
        }
    }
}
