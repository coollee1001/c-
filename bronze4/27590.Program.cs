// https://www.acmicpc.net/problem/27590

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

const int MAX_YEAR = 5000;
var sun = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
var moon = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

int sunEclipse = -sun[0] + sun[1];
int moonEclipse = -moon[0] + moon[1];

List<int> sunEclipses = new List<int>{sunEclipse};
List<int> moonEclipses = new List<int>{moonEclipse};

while(true){
    if(sunEclipse > MAX_YEAR && moonEclipse > MAX_YEAR) break;
    if(sunEclipse <= MAX_YEAR){
        sunEclipse += sun[1];
        sunEclipses.Add(sunEclipse);
    }
    if(moonEclipse <= MAX_YEAR){
        moonEclipse += moon[1];
        moonEclipses.Add(moonEclipse);
    }
}
HashSet<int> hs = new HashSet<int>(sunEclipses);
foreach(int element in moonEclipses){
    if(hs.Contains(element)){
        sw.WriteLine(element);
        break;
    }
}
sw.Close();

// github 업로드용 파일 백업
Filecopy fc = new Filecopy();
fc.copyLogic();
