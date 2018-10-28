let OzToGramsRatio = 28.34952;
let GramsToOzRatio = 0.03527396195;
let OutputText:HTMLDivElement = <HTMLDivElement> document.getElementById("outputText");
let OutputTextWholeUnits:HTMLDivElement = <HTMLDivElement> document.getElementById("outputTextWholeUnits");

document.getElementById("ouncesToGram").addEventListener("click", () => ouncesToGram());
document.getElementById("gramToOunces").addEventListener("click", () => gramToOunces());

function ConvertGramToOunces():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberInput")).value);
    return inputWeight * GramsToOzRatio;
}

function ConvertOuncesToGram():number{
    let inputWeight:number = Number((<HTMLInputElement>document.getElementById("numberInput")).value);
    return inputWeight * OzToGramsRatio;
}

function gramToOunces(){
    let result:number = ConvertGramToOunces();
    if (result > 0){
        OutputText.innerHTML = result.toString() + " ounces";
        OutputTextWholeUnits.innerHTML = "(" + (result/16).toFixed(2).toString() + " pounds)";
    }
}

function ouncesToGram(){
    let result:number = ConvertOuncesToGram();
    if (result > 0){
        OutputText.innerHTML = result.toString() + " gram";
        OutputTextWholeUnits.innerHTML = "(" + (result/1000).toFixed(2).toString() + " kilos)";
    }
}