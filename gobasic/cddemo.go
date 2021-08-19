package main

// 那个叫做tag，还可以根据你的喜好，自己写tag，然后读取出来用
/*
因为值中含义双引号字符，因此成员Tag一般用原生字符串面值的形式书写。
json开头键名对应的值用于控制encoding/json包的编码和解码的行为，
并且encoding/...下面其它的包也遵循这个约定。
成员Tag中json对应值的第一部分用于指定JSON对象的名字
*/
type response2 struct {
    Page   int      `json:"page"` //这个是被json解析以后,转换json后的key名
    Fruits []string `json:"fruits"`
}
import "fmt"

func main() {
	var a string = `Hello`
	fmt.Printf("%s", a)
}
