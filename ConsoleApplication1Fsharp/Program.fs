// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.



//общие функци, которые могут пригодится во всех задачах
let inline (^) x y = pown x y // степень числа
let inline square x  = x ^ 2 //квадрат числа

//1 найти сумму кубов трех чисел
let sumofCubesSeq seq = seq |> Seq.sumBy (fun e -> e ^ 3)
let sumOfCubes x y z = [x; y; z;] |> sumofCubesSeq
let asdsfag = sumOfCubes 5 3 2

//2. Даны 2 числа найти среднее арифметическое их квадратов и среднее арифметическое их модулей
let inline sumOf func a b = (func a + func b) / 2.0
let testSumOfSquare = sumOf square 5.0 6.0
let testSumOfabs = sumOf abs -5.0 6.0

//3. Длины сторон первого прямоугольника равны a b, его площадь в шесть раз меньше площади второго прямоугольника
// Найти длину второго прямоугольника d, если длина одной из его сторон равна с
// c*d = a*b*6
let ribD a b c = (6.0 * a * b) / c

//4. Найти корни квадратного уравнения ax^2 + bx + c =0 c заданными коэффициентами a b c (a<>0)
//Если известно, что дискриминант неотрицателен
let sqrtD a b c = sqrt ((b^2) - 4.0 * a * c)
let root func a b c = func (-b/(2.0*a)) ((sqrtD a b c)/(2.0*a))
let roots a b c = (root (+) a b c, root (-) a b c)
let testRoots = roots 1.0 3.0 -4.0

//5.Посчитать сумму чисел трехзначного числа x 
let rec sumOfFigures (x:int) =  
    match x with
    | 0 -> 0
    | x -> (x % 10) + sumOfFigures (x / 10)
let testsSumOfFigures = sumOfFigures 537

//6. Найти минимум двух максимумов min(max(a,b), max(c,d))
let inline minOfmaxs a b c d = min (max a b) (max c d)
let testMin = minOfmaxs 1 2 5 4
let testMinFloat = minOfmaxs 1.0 2.0 5.0 4.0

//7.Дано четырехзначное натральное число n найти сумму первой и последней цифры этого числа
let lastFigure x = x % 10
let countFigures x = int (log10 (float x)) 
let firstFigure (x:int) = x / (pown 10 (countFigures x))  
let sumFirstAndLast x = firstFigure x + lastFigure x 


let testasdasf=  sumFirstAndLast 123432525
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 
    // return an integer exit codedsjks
