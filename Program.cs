/*
void Main(){
    double radie = 2.4;
    Console.WriteLine("cirkelens omcrets: " +Omkrets(radie));
    Console.WriteLine("Cirklens area: " + Area(radie));
}
double Area(double r) {
    double area = Math.Pow(r, 2)*Math.PI;
    return area;
}
double Omkrets(double r){
    double om = r+r*Math.PI;
    return om;
}

Main();*/
Main();

void Main (){
    float moon = 0.323445F ;
    float sun = 2.233741F ;
    float ultra = 1.237628F;
    Console.WriteLine(omega(ultra,sun,moon));
}
float omega (float sun ,float moon ,float ultra ){
    float omega = (sun + moon + ultra) / 2 ;
    return omega;
}