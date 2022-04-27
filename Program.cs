// tic tac toe

string tl = "7";
string tm = "8";
string tr = "9";
string ml = "4";
string mm = "5";
string mr = "6";
string bl = "1";
string bm = "2";
string br = "3";
Console.WriteLine(tl +"|"+ tm + "|" + tr);
Console.WriteLine("-+-+-");
Console.WriteLine(ml +"|"+ mm + "|" + mr);
Console.WriteLine("-+-+-");
Console.WriteLine(bl +"|"+ bm + "|" + br);
bool check_win(){
    if (String.Equals(tl,tm) && (String.Equals(tm,tr))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(ml,mm) && (String.Equals(mm,mr))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(bl,bm) && (String.Equals(bm,br))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(tl,ml) && (String.Equals(ml,bl))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(tm,mm) && (String.Equals(mm,bm))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(tr,mr) && (String.Equals(mr,br))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(tl,mm) && (String.Equals(mm,br))){
        Console.WriteLine("You win");
        return true;
        }
    if (String.Equals(tr,mm) && (String.Equals(mm,bl))){
        Console.WriteLine("You win");
        return true;
        }
    return false;
}


for (int i = 0; i < 9; i++){
    Console.WriteLine("player 1 O's chose a tile");
    string choice = Console.ReadLine();
    if (choice == "1"){
        bl = "O";
    }
    if (choice == "2"){
        bm = "O";
    }
    if (choice == "3"){
        br = "O";
    }if (choice == "4"){
        ml = "O";
    }if (choice == "5"){
        mm = "O";
    }if (choice == "6"){
        mr = "O";
    }if (choice == "7"){
        tl = "O";
    }if (choice == "8"){
        tm = "O";
    }if (choice == "9"){
        tr = "O";
    }
    if (choice == "n"){
        break;
    }
    Console.WriteLine(tl +"|"+ tm + "|" + tr);
    Console.WriteLine("-+-+-");
    Console.WriteLine(ml +"|"+ mm + "|" + mr);
    Console.WriteLine("-+-+-");
    Console.WriteLine(bl +"|"+ bm + "|" + br);
    //check_win();
    if (check_win() == true){
        break;
    }
    Console.WriteLine("player 2 X's chose a tile");
    choice = Console.ReadLine();
    if (choice == "1"){
        bl = "X";
    }
    if (choice == "2"){
        bm = "X";
    }
    if (choice == "3"){
        br = "X";
    }if (choice == "4"){
        ml = "X";
    }if (choice == "5"){
        mm = "X";
    }if (choice == "6"){
        mr = "X";
    }if (choice == "7"){
        tl = "X";
    }if (choice == "8"){
        tm = "X";
    }if (choice == "9"){
        tr = "X";
    }
    if (choice == "n"){
        break;
    }
    Console.WriteLine(tl +"|"+ tm + "|" + tr);
    Console.WriteLine("-+-+-");
    Console.WriteLine(ml +"|"+ mm + "|" + mr);
    Console.WriteLine("-+-+-");
    Console.WriteLine(bl +"|"+ bm + "|" + br);
    //check_win();
    if (check_win() == true){
        break;
    }
}