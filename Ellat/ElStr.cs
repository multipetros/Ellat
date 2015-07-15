using System;
using System.Text.RegularExpressions ;

namespace Multipetros.Text{
	/// <summary>
	/// Class with usefull functions for modern greek unicode text manipulation
	/// Version 2.0
	/// Copyright (c) 2014, Petros Kyladitis <petros.kyladitis@gmail.com>
	/// FreeBSD License <http://www.multipetros.gr/freebsd-license/>
	/// </summary>
	public class ElStr{
		public ElStr(){}
		//
		// arrays for to_latin function usage
		//
		
		//difthongs
		private string[] EL_DIFTHONGS = {
			"αι","αί","οι","οί","ου","ού","ει","εί","ντ","τσ","τζ","γγ","γκ","γχ","γξ","θ","χ","ψ",
			"ΑΙ","ΑΊ","ΟΙ","ΟΊ","ΟΥ","ΟΎ","ΕΙ","ΕΊ","ΝΤ","ΤΣ","ΤΖ","ΓΓ","ΓΚ","ΓΧ","ΓΞ","Θ","Χ","Ψ",
			"Αι","Αί","Οι","Οί","Ου","Ού","Ει","Εί","Ντ","Τσ","Τζ","Γγ","Γκ","Γχ","Γξ",
			"αΙ","αΊ","οΙ","οΊ","οΥ","οΎ","εΙ","εΊ","νΤ","τΣ","τΖ","γΓ","γΚ","γΧ","γΞ"
		} ;
		private string[] LAT_DIFTHONGS = {
			"ai","ai","oi","oi","ou","ou","ei","ei","nt","ts","tz","ng","gk","nch","nx","th","ch","ps",
			"AI","AI","OI","OI","OU","OU","EI","EI","NT","TS","TZ","NG","GK","NCH","NX","TH","CH","PS",
			"Ai","Ai","Oi","Oi","Ou","Ou","Ei","Ei","Nt","Ts","Tz","Ng","Gk","Nch","Nx",
			"aI","aI","oI","oI","oU","oU","eI","eI","nT","tS","tZ","nG","gK","nCH","nX"
		} ;
		
		//*υ difthongs case, if followed by letters at pos 1-3 converted to *f, else to *v
		private string[] EL_SPEC_DIFTHONGS = {
		"(α[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(ε[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(η[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(α[υ|ύ])",
		"(ε[υ|ύ])",
		"(η[υ|ύ])",
		"(Α[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Ε[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Η[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Α[Υ|Ύ])",
		"(Ε[Υ|Ύ])",
		"(Η[Υ|Ύ])",
		"(α[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(ε[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(η[Υ|Ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(α[Υ|Ύ])",
		"(ε[Υ|Ύ])",
		"(η[Υ|Ύ])",
		"(Α[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Ε[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Η[υ|ύ])(?![α|ά|β|γ|δ|ε|έ|ζ|η|ή|λ|ι|ί|ϊ|ΐ|μ|ν|ο|ό|ρ|ω|ώ|Α|Ά|Β|Γ|Δ|Ε|Έ|Ζ|Η|Ή|Λ|Ι|Ί|Ϊ|Ϊ|Μ|Ν|Ο|Ό|Ρ|Ω|Ώ|])",
		"(Α[υ|ύ])",
		"(Ε[υ|ύ])",
		"(Η[υ|ύ])"
		} ;
		private string[] LAT_SPEC_DIFTHONGS = {
			"af","ef","if","av","ev","iv",
			"AF","EF","IF","AV","EV","IV",
			"aF","eF","iF","aV","eV","iV",
			"Af","Ef","If","Av","Ev","Iv"
		} ;
		
		//μπ difthong case, inner word "μπ" converted to "mp", "μπ" at word boundaries with "b"
		private string[] EL_MP_DIFTHONGS = {
			"\\Bμπ\\B","μπ",
			"\\BΜΠ\\B","ΜΠ",
			"\\BΜπ\\B","Μπ",
			"\\BμΠ\\B","μΠ"
		} ;
		private string[] LAT_MP_DIFTHONGS = {
			"mp", "b",
			"MP","B",
			"Mp","B",
			"mP","B"
		} ;
		
		//one fthong letters convertions
		private string[] EL_LETTERS = {
			"α|ά","β","γ","δ","ε|έ","ζ","η|ή|ι|ί|ϊ|ΐ","κ","λ","μ","ν","ξ","ο|ό|ω|ώ","π","ρ","σ|ς","τ","υ|ύ|ϋ|ΰ","φ",
			"Α|Ά","Β","Γ","Δ","Ε|Έ","Ζ","Η|Ή|Ι|Ί|Ϊ|Ϊ","Κ","Λ","Μ","Ν","Ξ","Ο|Ό|Ω|Ώ","Π","Ρ","Σ|Σ","Τ","Υ|Ύ|Ϋ|Ϋ","Φ"
		} ;
		private string[] LAT_LETTERS = {
			"a","v","g","d","e","z","i","k","l","m","n","x","o","p","r","s","t","y","f",
			"A","V","G","D","E","Z","I","K","L","M","N","X","O","P","R","S","T","Y","F"
		} ;
		
		//
		// arrays for accent replacements usage
		//
		private string[] UPPER_ACCENT_LETTERS = {"Ά","Έ","Ή", "Ί|Ϊ", "Ό", "Ύ|Ϋ", "Ώ"} ;
		private string[] UPPER_NO_ACCENT_LETTERS = {"Α","Ε","Η", "Ι", "Ο", "Υ", "Ω"} ;
		
		/// <summary>
		/// Method to convert predefined tables at uppercase,
		/// for more speed, using predefined uppercase tables instead.
		/// </summary>
		/// <param name="lowercaseArray">String array, to convert</param>
		/// <returns>A new string array, with all elements at uppercase</returns>
		private string[] UpperCaseArray(string[] lowercaseArray){
			int arrayLen = lowercaseArray.Length ;
			string[] uppercaseArray = new string[arrayLen] ;
			for(int i=0; i<arrayLen; i++){
				uppercaseArray[i] = lowercaseArray[i].ToUpper() ;
			}
			return uppercaseArray ;
		}
		
		/// <summary>
		///  Replace the letters of a string defined at the 1st array, with letters defined at the 2nd array
		/// (for example, 1st array:['a','b'] - 2nd array:['y','z'] - string: "abstract" => "yzstryct")
		/// </summary>
		/// <param name="currentLettersArray">Array with letters to search</param>
		/// <param name="becomeLettersArray">Array with letters to replace</param>
		/// <param name="strToReplace">String to replace letters</param>
		/// <returns>String  with letters replaced</returns>
		private string ReplaceLetters(string[] currentLettersArray, string[] becomeLettersArray, string strToReplace){
			int arrayLen = currentLettersArray.Length ;
			for(int i=0; i<arrayLen; i++){
				strToReplace = Regex.Replace(strToReplace, currentLettersArray[i], becomeLettersArray[i]) ;
			}
			return strToReplace ;
		}
		
		/// <summary>
		/// Convert greek letters at the string to latins, as ISO:843 defines
		/// </summary>
		/// <param name="strToLatin">string to convert</param>
		/// <returns>converted string</returns>
		public string ToLatin(string strToLatin){
			strToLatin = ReplaceLetters(EL_DIFTHONGS, LAT_DIFTHONGS, strToLatin) ;
			strToLatin = ReplaceLetters(EL_MP_DIFTHONGS, LAT_MP_DIFTHONGS, strToLatin) ;
			strToLatin = ReplaceLetters(EL_SPEC_DIFTHONGS, LAT_SPEC_DIFTHONGS, strToLatin) ;
			strToLatin = ReplaceLetters(EL_LETTERS, LAT_LETTERS, strToLatin) ;
			
			return strToLatin ;
		}
		
		/// <summary>
		/// Convert unicode string to upper case, without accent marks for the greek letters
		/// </summary>
		/// <param name="strToUpper">string to upper case convert</param>
		/// <returns>converted string</returns>
		public string ToUpperCaseNoAccent(string strToUpper){
			strToUpper = strToUpper.ToUpper() ;
			strToUpper = ReplaceLetters(UPPER_ACCENT_LETTERS, UPPER_NO_ACCENT_LETTERS, strToUpper) ;
			return strToUpper ;
		}
	}
}