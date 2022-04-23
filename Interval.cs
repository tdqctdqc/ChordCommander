using Godot;
using System;
using System.Collections.Generic;

public class Interval 
{
    public static List<Interval> Intervals; 
    public static Dictionary<int, Dictionary<int, Interval>> IntervalDictionary; 
    public static Interval DiminishedUnison, PerfectUnison, AugmentedUnison;
    public static Interval DiminishedSecond, MinorSecond, MajorSecond, AugmentedSecond;
    public static Interval DiminishedThird, MinorThird, MajorThird, AugmentedThird;
    public static Interval DiminishedFourth, PerfectFourth, AugmentedFourth;
    public static Interval DiminishedFifth, PerfectFifth, AugmentedFifth;
    public static Interval DiminishedSixth, MinorSixth, MajorSixth, AugmentedSixth;
    public static Interval DiminishedSeventh, MinorSeventh, MajorSeventh, AugmentedSeventh;
    
    public int DiatonicWidth;
    public int ChromaticWidth; 
    private Interval(int dia, int chrom)
    {
        DiatonicWidth = dia;
        ChromaticWidth = chrom; 
        Interval.Intervals.Add(this);
        IntervalDictionary[DiatonicWidth].Add(ChromaticWidth, this);
    }

    public void Init()
    {
        IntervalDictionary = new Dictionary<int, Dictionary<int, Interval>>();

        Dictionary<int, Interval> UnisonDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(0 , UnisonDic);
        Dictionary<int, Interval> SecondDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(1 , SecondDic);
        Dictionary<int, Interval> ThirdDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(2 , ThirdDic);
        Dictionary<int, Interval> FourthDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(3 , FourthDic);
        Dictionary<int, Interval> FifthDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(4 , FifthDic);
        Dictionary<int, Interval> SixthDic = new Dictionary<int, Interval>();
        IntervalDictionary.Add(5 , SixthDic);
        Dictionary<int, Interval> SeventhDic = new Dictionary<int, Interval>(); 
        IntervalDictionary.Add(6 , SeventhDic);


        DiminishedUnison = new Interval(0,-1);
        PerfectUnison= new Interval(0,0);
        AugmentedUnison= new Interval(0,1);

        DiminishedSecond= new Interval(1,0);
        MinorSecond= new Interval(1,1);
        MajorSecond= new Interval(1,2);
        AugmentedSecond= new Interval(1,3);
        

        DiminishedThird= new Interval(2,2);
        MinorThird= new Interval(2,3);
        MajorThird= new Interval(2,4);
        AugmentedThird= new Interval(2,5);
        

        DiminishedFourth= new Interval(3,4);
        PerfectFourth= new Interval(3,5);
        AugmentedFourth= new Interval(3,6);


        DiminishedFifth= new Interval(4,6);
        PerfectFifth= new Interval(4,7);
        AugmentedFifth= new Interval(4,8);


        DiminishedSixth= new Interval(5,7);
        MinorSixth= new Interval(5,8);
        MajorSixth= new Interval(5,9);
        AugmentedSixth= new Interval(5,10);

        DiminishedSeventh= new Interval(6,9);
        MinorSeventh= new Interval(6,10);
        MajorSeventh= new Interval(6,11);
        AugmentedSeventh= new Interval(6,12);   
    }
}
