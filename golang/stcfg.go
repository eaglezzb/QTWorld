package main

import (
	"encoding/json"
	"fmt"
)

type Person struct {
	Name string
	Age  int
}

type User struct {
	username string `json:"username"`
	sex      string `json:"sex"`
}

func main() {
	a := Person{
		Name: "Eagle",
		Age:  18,
	}
	fmt.Printf("%s", "Hello")
	fmt.Printf(" \n %s %d", a.Name, a.Age)

	user := &User{
		username: "E",
		sex:      "男",
	}
	data, _ := json.Marshal(user)

	fmt.Printf("json str:%s\n", string(data))
}
