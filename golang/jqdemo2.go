package main

import (
	"fmt"

	"github.com/elgs/gojq"
)

var jsonArray = `
[
  {
    "name": "elgs",
    "gender": "m",
    "skills": [
      "Golang",
      "Java",
      "C"
    ]
  },
  {
    "name": "enny",
    "gender": "f",
    "skills": [
      "IC",
      "Electric design",
      "Verification"
    ]
  },
  {
    "name": "sam",
    "gender": "m",
	"pet": null,
    "skills": [
      "Eating",
      "Sleeping",
      "Crawling"
    ]
  }
]
`

func main() {
	parser, err := gojq.NewStringQuery(jsonArray)
	if err != nil {
		fmt.Println(err)
		return
	}
	samSkills, err := parser.Query("[2].skills")
	fmt.Println(samSkills, err) //[Eating Sleeping Crawling] <nil>
	samSkillParser := gojq.NewQuery(samSkills)
	fmt.Println(samSkillParser.Query("[1]")) //Sleeping <nil>
}
