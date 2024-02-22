
#include<bits/stdc++.h>
using namespace std; 
// int n, c[105][105];
// int N , X[100];
int n, c[105][105], X[100];
int visited[105];
int d = 0, ans = INT_MAX,cmin = INT_MAX;
vector<int> path, bestPath;
void Nhap(){
   cin>>n;
   for(int i=1;i<=n;i++){
      for(int j=1;j<=n;j++){
         cin>>c[i][j];
         if(c[i][j] !=0){
            cmin = min(cmin,c[i][j]);
         }
      }
   }
   memset(visited,0,sizeof(visited));

}


void updateBestPath() {
    bestPath = path;
}

void Try(int i){
   for(int j=1;j<=n;j++){
      if(visited[j] == 0){
         visited[j] = 1;
         X[i] = j;
         d += c[X[i-1]][X[i]];
         path.push_back(j); // Thêm đỉnh vào đường đi
         if(i==n){
            ans = min(ans,d+c[X[n]][1]);
            if (ans == d+c[X[n]][1]) {
                updateBestPath(); // Cập nhật đường đi tối ưu
            }
         }
         else if(d + (n-i+1)*cmin <=ans){
            Try(i+1);
         }
         visited[j] = 0;
         d-=c[X[i-1]][X[i]];
         path.pop_back(); // Loại bỏ đỉnh khỏi đường đi
      }
   }
}

int main(){
   // freopen("travle.inp","r",stdin);
   // freopen("travle.out","w",stdout);
   Nhap();
   X[1] = 1; visited[1] = 1;
   path.push_back(1); // Thêm đỉnh đầu tiên vào đường đi
   Try(2);
   cout<<ans<<endl;
   // In đường đi tối ưu
   for(int i=0; i<bestPath.size(); i++){
      cout << bestPath[i] << " ";
   }
   cout << endl;
   system("pause");
   return 0;
}

