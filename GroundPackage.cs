using System;
using static System.Console;
public class GroundPackage
{
    public GroundPackage(int ozip, int dzip, double l, double wi, double h, double we) // 6 parameter constructor - sets the properties
    {
        OriginZip = ozip;
        DestinationZip = dzip;
        Length = l;
        Width = wi;
        Height = h;
        Weight = we;
    }

    public const int VALID_ZIP_ZERO = 0; // constant - greater than 00000
    public const int VALID_ZIP_NINE = 99999; // constant - less than 99999
    public const int DEFAULT_FR_ZIP = 40202; // constant - default if bad o zip
    public const int DEFAULT_TO_ZIP = 90210; // constant - default if bad d zip


    public const double POSITIVE_CHECK = 0; // constant - check if positive
    public const double DEFAULT_VALUE = 1; // constant - default to 1 if negative

    public const int DISTANCE_DIVIDER = 10000; // constant - divide zips by 10,000

    private int _originZip; // origin zip backing field
    private int _destZip; // destination zip backing field
    private double _length; // length backing field
    private double _width; // width backing field
    private double _height; // height backing field
    private double _weight; // weight backing field
    private int _zoneDistance; // zone distance backing field

    public int OriginZip // Origin zip code Property
    {
        //Precondition: None
        //Postcondition: Returns the origin zip code
        get
        {
            return _originZip;
        }

        //Precondition: zip must be between 00000 and 99999 to pass validation
        //Postcondiion: the origin zip has been assigned to the specified value
        set
        {
            if (value >= VALID_ZIP_ZERO && value <= VALID_ZIP_NINE)
                _originZip = value;
            else
                _originZip = DEFAULT_FR_ZIP;
        }
    }
    public int DestinationZip // Destination zip code Property
    {
        //Precondition: None
        //Postcondition: Returns the destination zip code
        get
        {
            return _destZip;
        }

        //Precondition: must be between 00000 and 99999 to pass validation
        //Postcondition: the destination zip code has been set to the specified value
        set
        {
            if (value <= VALID_ZIP_ZERO || value >= VALID_ZIP_NINE)
                _destZip = DEFAULT_TO_ZIP;
            else
                _destZip = value;
        }
    }
    public double Length // Package length Property
    {
        //Pre: None
        //Post: Returns the length
        get
        {
            return _length;
        }

        //Pre: must be positive
        //Post: the length has been set to the specified value
        set
        {
            if (value > POSITIVE_CHECK)
                _length = value;
            else
                _length = DEFAULT_VALUE;
        }
    }
    public double Width // Package width Property
    {
        // Pre: None
        // Post: Returns the width
        get
        {
            return _width;
        }

        // Pre: Must be positive
        // Post: the width has been set to the specified value
        set
        {
            if (value > POSITIVE_CHECK)
                _width = value;
            else
                _width = DEFAULT_VALUE;
        }
    }
    public double Height // Package height Property
    {
        // Pre: None;
        // Post: Returns the height
        get
        {
            return _height;
        }

        // Pre: Must be positive
        // Post: the height has been set to the specified value
        set
        {
            if (value > POSITIVE_CHECK)
                _height = value;
            else
                _height = DEFAULT_VALUE;
        }
    }
    public double Weight // Package weight Property
    {
        //Pre: None
        // Post: returns the weight
        get
        {
            return _weight;
        }

        // Pre: Must be positive
        // Post: the weight has been set to the specified value
        set
        {
            if (value > POSITIVE_CHECK)
                _weight = value;
            else
                _weight = DEFAULT_VALUE;
        }
    }
    public int ZoneDistance // Package read-only zone distance Property
    {
        //Pre: must be positive and must be provided origin and destination zip
        //Post: returns the zone distance
        get
        {
            _zoneDistance = Math.Abs((_originZip / DISTANCE_DIVIDER)
                                     - (_destZip / DISTANCE_DIVIDER));
            return _zoneDistance;
        }
    }

    public double CalcCost() // Calculate cost method
    {
        double cost;

        const double SIZE_COST_FACTOR = 0.25;
        const double WEIGHT_COST_FACTOR = 0.45;
        const double ADD_ONE = 1;

        cost = (SIZE_COST_FACTOR * (_length * _width * _height))
             + (WEIGHT_COST_FACTOR * (_zoneDistance + ADD_ONE) * _weight);

        return cost;
    }

    //Precondition: None
    //Postcondition: The package's information is returned as a formatted string.
    public override string ToString()
    {
        return $"Origin Zip: {OriginZip:D5}{Environment.NewLine}" +
            $"Destination Zip: {DestinationZip:D5}{Environment.NewLine}" +
            $"Length: {Length:F1}{Environment.NewLine}" +
            $"Width: {Width:F1}{Environment.NewLine}" +
            $"Height: {Height:F1}{Environment.NewLine}" +
            $"Weight: {Weight:F1}{Environment.NewLine}" +
            $"Zone Distance: {ZoneDistance}";
    }
}
