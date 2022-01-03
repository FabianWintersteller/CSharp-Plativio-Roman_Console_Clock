using System;
using System.Timers;
namespace Roman_Clock {
 class Program {
  public static void SetTimer( ) {
   Timer timer = new Timer( 1000 );
   timer.Elapsed += Timer_Elapsed;
   timer.AutoReset = true;
   timer.Enabled = true;
   }
  public static void Timer_Elapsed( object sender,ElapsedEventArgs e ) {
   DateTime now = DateTime.Now;
   Console.Clear( );
   Console.Write( "{0}:{1}:{2}",Trans( now.Hour ),Trans( now.Minute ),Trans( now.Second ) );
   }
  public static string Trans( int input ) {
   string[ ] rom = new string[ ] { "I","IV","V","IX","X","XL","L" };
   int[ ] trans = new int[ ] { 1,4,5,9,10,40,50 };
   string result = "";
   if( input == 0 ) {
    return "N";
    }
   else {
    for( int i = 6 ; i >= 0 ; i-- ) {
     while( input >= trans[ i ] ) {
      input -= trans[ i ];
      result += rom[ i ];
      }
     }
    return result;
    }
   }
  static void Main( string[ ] args ) {
   SetTimer( );
   Console.ReadLine( );
   }
  }
 }