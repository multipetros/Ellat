using System ;
using Microsoft.Win32 ;

namespace Multipetros.Utils{
	/// <summary>
	/// Store and load setting at the MS Windows Registry in simplicity.
	/// Version 1.0
	/// Copyright (c) 2014, Petros Kyladitis <petros.kyladitis@gmail.com>
	/// FreeBSD License <http://www.multipetros.gr/freebsd-license/>
	/// </summary>
	public class RegistrySettings{
		private string companyName ;
		private string productName ;
		
		/// <summary>
		/// Default constructor, with parameters to specify the registry path formated as
		/// HKEY_CURRENT_USER\Software\CompanyName\ProductName
		/// </summary>
		/// <param name="companyName">The companys name. Recomended to use Application.CompanyName property.</param>
		/// <param name="productName">The product's name. Recomended to use Application.ProductName property.</param>
		public RegistrySettings(string companyName, string productName){
			this.companyName = companyName ;
			this.productName = productName ;
		}
		
		/// <summary>Create a RegistryKey object to store or load values</summary>
		/// <returns>Created RegistryKey object</returns>
		private RegistryKey ApplicationRegKey(){
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true) ;
			key.CreateSubKey(companyName) ;
			key = key.OpenSubKey(companyName, true) ;
			key.CreateSubKey(productName) ;
			key = key.OpenSubKey(productName, true) ;
			return key ;
		}
		
		/// <summary>Load settings from the Registry</summary>
		/// <param name="settingKey">Name of the key</param>
		/// <returns>The stored value, on error, empty or not existed key, return an empty string</returns>
		public string GetSetting(string settingKey){
			try {
				RegistryKey key = ApplicationRegKey() ;
				if(key != null){
					string val = key.GetValue(settingKey).ToString() ;
					key.Close() ;
					return val ;
				}else{
					return "" ;
				}				
			} catch (Exception) {
				return "" ;
			}

		}
		
		/// <summary>Store setting to the Registry</summary>
		/// <param name="settingKey">Name of the key</param>
		/// <param name="settingValue">Value to store</param>
		/// <returns>True if done, false on any exception</returns>
		public bool SetSetting(string settingKey, string settingValue){
			try {
				RegistryKey key = ApplicationRegKey() ;
				key.SetValue(settingKey, settingValue) ;
				key.Close() ;
				return true ;
			} catch (Exception) {
				return false ;
			}
			
		}
	}
}
