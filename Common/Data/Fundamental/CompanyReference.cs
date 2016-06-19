/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

//------------------------------------------------------------------------------
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;

namespace QuantConnect.Data.Fundamental
{
	/// <summary>
	/// Definition of the CompanyReference class
	/// </summary>
	public class CompanyReference
	{
		/// <summary>
		/// 10-digit unique and unchanging Morningstar identifier assigned to every company.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 1
		/// </remarks>
		public string CompanyId { get; set; }

		/// <summary>
		/// 25-character max abbreviated name of the firm.  In most cases, the short name will simply be the Legal Name less the
		/// “Corporation”, “Corp.”, “Inc.”, “Incorporated”, etc…
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 2
		/// </remarks>
		public string ShortName { get; set; }

		/// <summary>
		/// The English translation of the foreign legal name if/when applicable.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 3
		/// </remarks>
		public string StandardName { get; set; }

		/// <summary>
		/// The full name of the registrant as specified in its charter, and most often found on the front cover of the 10K/10Q/20F filing.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 4
		/// </remarks>
		public string LegalName { get; set; }

		/// <summary>
		/// 3 Character ISO code of the country where the firm is domiciled. See separate reference document for Country Mappings.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 5
		/// </remarks>
		public string CountryId { get; set; }

		/// <summary>
		/// The Central Index Key; a corporate identifier assigned by the Securities and Exchange Commission (SEC).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 6
		/// </remarks>
		public string CIK { get; set; }

		/// <summary>
		/// At the Company level; each company is assigned to 1 of 3 possible status classifications; (U) Public, (V) Private, or (O) Obsolete:
		///  Public-Firm is operating and currently has at least one common share class that is currently trading on a public exchange.
		///  Private-Firm is operating but does not have any common share classes currently trading on a public exchange.
		///  Obsolete-Firm is no longer operating because it closed its business, or was acquired.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 9
		/// </remarks>
		public string CompanyStatus { get; set; }

		/// <summary>
		/// The Month of the company’s latest fiscal year.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 10
		/// </remarks>
		public int FiscalYearEnd { get; set; }

		/// <summary>
		/// This indicator will denote which one of the six industry data collection templates applies to the company.  Each industry data
		/// collection template includes data elements that are commonly reported by companies in that industry.  N=Normal
		/// (Manufacturing), M=Mining,  U=Utility, T=Transportation, B=Bank, I=Insurance
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 11
		/// </remarks>
		public string IndustryTemplateCode { get; set; }

		/// <summary>
		/// The 10-digit unique and unchanging Morningstar identifier assigned to the Primary Share class of a company. The primary share of a
		/// company is defined as the first share that was traded publicly and is still actively trading. If this share is no longer trading, the
		/// primary share will be the share with the highest volume.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 12
		/// </remarks>
		public string PrimaryShareClassID { get; set; }

		/// <summary>
		/// The symbol of the Primary Share of the company, composed of an arrangement of characters (often letters) representing a
		/// particular security listed on an exchange or otherwise traded publicly.   The primary share of a company is defined as the first share
		/// that was traded publicly and is still actively trading. If this share is no longer trading, the primary share will be the share with the
		/// highest volume. Note: Morningstar’s multi-share class symbols will often contain a “period” within the symbol; e.g. BRK.B for
		/// Berkshire Hathaway Class B.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 13
		/// </remarks>
		public string PrimarySymbol { get; set; }

		/// <summary>
		/// The Id representing the stock exchange of the Primary Share of the company.  See separate reference document for Exchange
		/// Mappings. The primary share of a company is defined as the first share that was traded publicly with and is still actively trading. If
		/// this share is no longer trading, the primary share will be the share with the highest volume.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 14
		/// </remarks>
		public string PrimaryExchangeID { get; set; }

		/// <summary>
		/// In some cases, different from the country of domicile (CountryId; DataID 5).  This element is a three (3) Character ISO code of the
		/// business country of the security.  It is determined by a few factors, including:
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 15
		/// </remarks>
		public string BusinessCountryID { get; set; }

		/// <summary>
		/// The language code for the foreign legal name if/when applicable.  Related to  DataID 4 (LegalName).
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 16
		/// </remarks>
		public string LegalNameLanguageCode { get; set; }

		/// <summary>
		/// The legal (registered) name of the company’s current auditor. Distinct from DataID 28000 Period Auditor that identifies the Auditor
		/// related to that period’s financial statements.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 17
		/// </remarks>
		public string Auditor { get; set; }

		/// <summary>
		/// The ISO code denoting the language text for Auditor’s name and contact information.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 18
		/// </remarks>
		public string AuditorLanguageCode { get; set; }

		/// <summary>
		/// The legal (registered) name of the current legal Advisor of the company.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 19
		/// </remarks>
		public string Advisor { get; set; }

		/// <summary>
		/// The ISO code denoting the language text for Advisor's name and contact information.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 20
		/// </remarks>
		public string AdvisorLanguageCode { get; set; }

		/// <summary>
		/// Indicator to denote if the company is a limited partnership, which is a form of business structure comprised of a general partner and
		/// limited partners. 1 denotes it is a LP; otherwise 0.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 21
		/// </remarks>
		public bool IsLimitedPartnership { get; set; }

		/// <summary>
		/// Indicator to denote if the company is a real estate investment trust (REIT). 1 denotes it is a REIT; otherwise 0.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 22
		/// </remarks>
		public bool IsREIT { get; set; }

		/// <summary>
		/// The MIC (market identifier code) of the PrimarySymbol of the company. See Data Appendix A for the relevant MIC to exchange
		/// name mapping.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 23
		/// </remarks>
		public string PrimaryMIC { get; set; }

		/// <summary>
		/// This refers to the financial template used to collect the company’s financial statements. There are two report styles representing
		/// two different financial template structures. Report style “1” is most commonly used by US and Canadian companies, and Report
		/// style “3” is most commonly used by the rest of the universe. Contact your client manager for access to the respective templates.
		/// </summary>
		/// <remarks>
		/// Morningstar DataId: 24
		/// </remarks>
		public int ReportStyle { get; set; }

	}
}
