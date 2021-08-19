package main

import "fmt"

func plus(a int, b int) int {
	return a + b
}

func main() {
	var sd [2]string
	sd[1] = "string only"
	fmt.Printf("%s", sd)

	var a [5]int
	fmt.Println("default:", a)

	fmt.Println("the sum is :", plus(1, 2))

	i := 2
	fmt.Print("write ", i, "as \n")
	switch i {
	case 1:
		fmt.Printf("The one")
	case 2:
		fmt.Printf("The Two")
	default:
		fmt.Printf("不在接收范围")
	}
}
