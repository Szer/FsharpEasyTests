
let qwe = 1

let rec factorial x = 
    if x<=1 then 1
    else 
        x * factorial (x-1)  

let rec (!) x = 
    if x<=1 then 1
    else 
        x * (!) (x-1)  

let test = !5

let (===) a b c = 
    true


["asd"; "asd"] |> List.iter (fun s -> printfn "s has length %d" s.Length)

let toString (x : int) = x.ToString()
let strLen (x : string) = x.Length

//let lenOfSquare = square >> toString >> strLen