namespace VolcanoProjectTests;

public class Tests
{
    VolcanoAnalyzer? va;

    [SetUp]
    public void Setup()
    {
        va = new VolcanoAnalyzer();
        va.loadVolcanoes("volcano.json");
    }

    [Test]
    public void volcanoExists() {
        //Setup
        Volcano classUnderTest = new Volcano();

        //Execute


        //Assert
        Assert.NotNull(classUnderTest);

        //Teardown
    }

    [Test]
    public void loadVolcanoes(){
        //Setup
        int expected = 804;
        int actual = -1;
        //Execute
        if(va is not null)
        {
            actual = va.numVolcanoes();
        } 
        

        //Assert
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void eruptedInEighties() {
        //Setup
        int expected = 40;

        //Execute
        int actual = 0; //va.eruptedInEighties().size();

        //Assert
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void highVEI() {
        //Setup
        string[] expected = { "Macauley Island", "Kikai", "Masaya", "Pago", "Taal", "Pinatubo", "Long Island", "Black Peak", "St. Helens", "Veniaminof", "Aniakchak", "Santorini", "Taupo", "Pago", "Pinatubo", "Raoul Island", "Okmok", "Apoyeque", "Ambrym", "Bona-Churchill", "Taupo", "Ksudach", "Ilopango", "Rabaul", "Pago", "Bona-Churchill", "Dakataua", "Ceboruco", "Changbaishan", "Quilotoa", "Kuwae", "Bardarbunga", "Huaynaputina", "Long Island", "Tambora", "Krakatau", "Santa Maria", "Novarupta", "Pinatubo" };
         //Execute
        string[] actual = {}; //va.highVEI();
        //Assert
        if(expected is not null && actual is not null)
        {
            Assert.AreEqual(expected.Count(), actual.Count());
            Assert.AreEqual(expected, actual);
        }
        //Teardown
    }

    [Test]
    public void mostDeadly() {
        //Setup
        Volcano expected = new Volcano();
        expected.Year = 450;
        expected.Tsu = "";
        expected.EQ= "";
        expected.Name = "Ilopango";
        expected.Location="El Salvador";
        expected.Country="El Salvador";
        expected.Latitude=13.672;
        expected.Longitude=-89.053;
        expected.Elevation=450;
        expected.Type="Caldera";
        expected.VEI=6;
        expected.Agent="";
        expected.DEATHS="30000";

        //Execute
        Volcano actual = new Volcano(); //va.mostDeadly();

        //Assert
        Assert.AreEqual(expected.Year, actual.Year);
        Assert.AreEqual(expected.Tsu, actual.Tsu);
        Assert.AreEqual(expected.EQ, actual.EQ);
        Assert.AreEqual(expected.Name, actual.Name);
        Assert.AreEqual(expected.Location, actual.Location);
        Assert.AreEqual(expected.Country, actual.Country);
        Assert.AreEqual(expected.Latitude, actual.Latitude);
        Assert.AreEqual(expected.Longitude, actual.Longitude);
        Assert.AreEqual(expected.Elevation, actual.Elevation);
        Assert.AreEqual(expected.Type, actual.Type);
        Assert.AreEqual(expected.VEI, actual.VEI);
        Assert.AreEqual(expected.Agent, actual.Agent);
        Assert.AreEqual(expected.DEATHS, actual.DEATHS);
        //Teardown
    }

    [Test]
    public void causedTsunami() {
        //Setup
        double expected = 17;

        //Execute
        double actual = 0; //va.causedTsunami();

        //Assert
        Assert.AreEqual(expected, actual, .1);

        //Teardown
    }

    [Test]
    public void mostCommonType() {
        //Setup
        string expected = "Stratovolcano";

        //Execute
        string actual = ""; //va.mostCommonType();

        //Assert
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void eruptionsByCountry() {
        //Setup
        int expected1 = 47;
        int expected2 = 189;
        int expected3 = 0;

        //Execute
        int actual1 = 0; //va.eruptionsByCountry("United States");
        int actual2 = 0;//va.eruptionsByCountry("Indonesia");
        int actual3 = 0; //va.eruptionsByCountry("Zimbabwe");

        //Assert
        Assert.AreEqual(expected1, actual1);
        Assert.AreEqual(expected2, actual2);
        Assert.AreEqual(expected3, actual3);
        //Teardown
    }

    [Test]
    public void averageElevation() {
        //Setup
        double expected = 1993.71;

        //Execute
        double actual = 0.0; //va.averageElevation();

        //Assert
        Assert.AreEqual(expected, actual, .1);

        //Teardown
    }

    [Test]
    public void volcanoTypes() {
        //Setup
        string[] expected = { "Caldera", "Stratovolcano", "Complex volcano", "Shield volcano", "Pyroclastic shield", "Volcanic field", "Lava dome", "Subglacial volcano", "Crater rows", "Tuff cone", "Fissure vent", "Pyroclastic cone", "Submarine volcano", "Lava cone", "Pumice cone", "Mud volcano", "Cinder cone", "Compound volcano", "Maar"};
        //Execute
        string[] actual = {}; //va.volcanoTypes();

        //Assert
        Assert.AreEqual(expected.Count(), actual.Count());
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void percentNorth() {
        //Setup
        double expected = 64.55;

        //Execute
        double actual = 0.0; //va.percentNorth();

        //Assert
        Assert.AreEqual(expected, actual, .1);

        //Teardown
    }

    [Test]
    public void manyFilters() {
        //Setup
        string[] expected = { "Galunggung", "Hudson, Cerro" };
        //Execute
        string[] actual = {}; //va.manyFilters();

        //Assert
        Assert.AreEqual(expected.Count(), actual.Count());
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void elevatedVolcanoes() {
        //Setup
        string[] expected = { "Tungurahua", "Cotopaxi", "Bona-Churchill", "Bona-Churchill", "Ruiz", "Tungurahua", "Cotopaxi", "Cotopaxi", "Cotopaxi", "Cotopaxi", "Sabancaya", "Ararat", "Ruiz", "Cotopaxi", "Tungurahua", "Tungurahua", "Popocatepetl", "Sangay", "Ruiz", "Sabancaya", "Huila", "Popocatepetl", "Tungurahua", "Tungurahua", "Tungurahua", "Huila", "Tungurahua", "Huila", "Tungurahua", "Tungurahua", "Tungurahua", "Ubinas" };

        //Execute
        string[] actual = {}; //va.elevatedVolcanoes(4990);

        //Assert
        Assert.AreEqual(expected.Count(), actual.Count());
        Assert.AreEqual(expected, actual);

        //Teardown
    }

    [Test]
    public void topAgentsOfDeath() {
        //Setup
        string[] expected = { "P", "M", "W", "A", "I" };

        //Execute
        string[] actual = {}; //va.topAgentsOfDeath();

        //Assert
        Assert.AreEqual(expected.Count(), actual.Count());
        Assert.AreEqual(expected, actual);

        //Teardown
    }
}