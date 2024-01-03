module Add
    sub main()
        Dim num1,num2,sum,mul,minus,v,mode as decimal
            console.writeline("enter the first number:")
            num1=convert.toint32(console.readline())
            console.writeline("write second number:")
            num2=convert.toint32(console.readline())
            sum=num1+num2
            console.writeline("Sum: "&sum)
            mul=num1*num2
            console.writeline("Mul: "&mul)
            minus=num1-num2
            console.writeline("Minus: "&minus)
        v=num1/num2
          console.writeline("Div= "&v)
          v=num1\num2
          console.writeline("Div= "&v)
          mode=num1 MOD num2
          console.writeline("mod= "&mode)

            console.readline()

    end sub
end module