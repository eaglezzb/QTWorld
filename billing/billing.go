// C:\Users\Administrator\go\pkg\mod\github.com\mhenderson-so
// go mod init <project_name>
// go test
// https://docs.azure.cn/zh-cn/billing/billing-enterprise-api
// https://ea.azure.cn/api/v3Reporting/downloadUsageMonthlyStatementV2?enrollmentId=4641&month=2021/07&usageReportType=Detail
package main

import (
	"fmt"

	azureeabilling "github.com/mhenderson-so/azure-ea-billing"
)

var (
	//BaseURI is the base of the URI that will be used for accessing the Azure EA Billing portal
	BaseURI = "https://ea.azure.cn"
)

func main() {

	eab := azureeabilling.Config{
		EA:     "V5702004S0147",                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    //Your EA Number
		APIKey: "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6ImlkZHFTRFpLcHptM1p6aEpEQ2d6SlAtNjJObyJ9.eyJFbnJvbGxtZW50TnVtYmVyIjoiVjU3MDIwMDRTMDE0NyIsIklkIjoiN2ZiOTY2NGItYjBjNy00ZGQ4LTgzNDktODFkYzg2YWQ5ZjY2IiwiUmVwb3J0VmlldyI6IkVudGVycHJpc2UiLCJQYXJ0bmVySWQiOiIiLCJEZXBhcnRtZW50SWQiOiIiLCJBY2NvdW50SWQiOiIiLCJpc3MiOiJlYS5taWNyb3NvZnRhenVyZS5jb20iLCJhdWQiOiJjbGllbnQuZWEubWljcm9zb2Z0YXp1cmUuY29tIiwiZXhwIjoxNjQzNzg4NDYxLCJuYmYiOjE2Mjc4OTA4NjF9.CnqAvstONMxjWw3QcrshXX9SLl8bTb00_LCqxONy5MD0KrUYYma810g_YAcYolcuiXNU73R1Ly6mYQf5HPX8vD-fjg7C36-zpVPIA4th0_vI3i5ceiaIdEdz0gD2PeIqTxnLPyurRMOfKr0cfsdehmSVziB8vnBAwVyHDYTdh7S2lgExsgFu1C15Y_hu87nHPFVQt_HzvOCIYN129Ld0wWT-vPx7OfZv6nsfpk9u2XVxr_cm7lxWtpOkJLFSIzuaoDeB0TAH1rf6GFhBSNUhG8oUkJ6DViYe4M2gLUwbvrHBxhlYAS2ZKgaM7jzLDHmYAzeXwqOtS-YR2oVAdOgCvg", //Your EA Billing API Key
	}

	resp, err := eab.GetUsageReports() //Fetches the usage reports from the EA portal
	if err != nil {
		fmt.Println(err)
		return
	}
	//this is  the ea site download
	//https://ea.azure.cn/api/v3Reporting/downloadUsageMonthlyStatementV2?enrollmentId=4641&month=2021/08&usageReportType=Summary
	//https://ea.azure.cn/api/v3Reporting/downloadUsageMonthlyStatementV2?enrollmentId=4641&month=2021/08&usageReportType=Detail
	//https://ea.azure.cn/api/v3Reporting/downloadUsageMonthlyStatementV2?enrollmentId=4641&month=2021/08&usageReportType=PriceSheet

	//this is programe auto gennerate
	//rest/V5702004S0147/usage-report?month=2020-02&type=detail&fmt=Csv
	//rest/V5702004S0147/usage-report?month=2020-02&type=pricesheet&fmt=Csv
	//rest/V5702004S0147/usage-report?month=2020-02&type=summary&fmt=Csv 2020-02}

	sum := len(resp.AvailableMonths)

	for i := 0; i < sum; i++ {
		fmt.Printf("%s \n", resp.AvailableMonths[i])
	}

	//Fetches a specific month from the EA billing portal
	reports := eab.GetMonthReportsCSV(resp.AvailableMonths[0], azureeabilling.DownloadForStructs)

	//Convert the CSV reports to GoLang structs so we can access the data easier
	structs, err := reports.ConvertToStructs()
	if err != nil {
		fmt.Println(err)
		return
	}
	for _, l := range structs.DetailReport {
		fmt.Println(*l)
	}
}
