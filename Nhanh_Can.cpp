
#include<iostream>
#include<fstream>
#include<climits>
#define START 0
using namespace std;

int **a, n;

int *x; // chua cac ket qua duong di
int total = 0; // tong chi phi cua phuong an trong x
int *best; // chua ket qua tot nhat 
int totalBest; // tong chi phi tot nhat
bool *d; // kiem tra 1 thanh pho da tham chua : d[i] = true -> thanh pho i da tham

void  readData(){
    ifstream f;
    f.open("travel.inp",ios::in);
    f>>n;

    // Cap phat mang 2 chieu 
    a = new int*[n];
    for(int i=0;i<n;i++){
        a[i] = new int[n];
    }
    for(int i=0;i<n;i++){
        for(int j=0;j<n;j++){
            f>>a[i][j];

        }
     }
    f.close();
}


void initData(){
    readData();
    x = new int[n];
    best = new int[n];
    d = new bool[n];
    total = 0;
    totalBest = INT_MAX;
    for(int i=0;i<n;i++){
        d[i] = false;
    }
    x[0] = START;   // xuat phat tu thanh pho 1
    d[START] = true; // danh dau thanh pho da tham

}

void output(){
        ofstream f;
        f.open("travel.out",ios::out);

        f<<totalBest<<endl;
        for(int i=0;i<n;i++)
              f<<best[i]+1<<"->";
        f<<START+1<<endl;
        // for(int i=0;i<n;i++)
        //       cout<<best[i]+1<<"->";
        // cout<<START + 1<<"-Chi phi: "<<totalBest<<endl;
        f.close();
   
}
void update(){
    if(a[x[n-1]][START]>0 && total + a[x[n-1]][START] <totalBest){
        totalBest = total + a[x[n-1]][START];
        for(int i=0;i<n;i++){
            best[i] = x[i];
        }
    }
}
int count = 0;
void travel(int idx){
    // dieu kien nhanh can
    if(total > totalBest){
        return ;
    }
    count +=1;
    // xac dinh si --> duyet qua cac thanh pho chua tham
    for(int i=0;i<n;i++){
        if(d[i]==false && a[x[idx-1]][i]){//x[idx-1] se chua diem ban dau vd 0 la ban dau 
            x[idx] = i;
            d[i] = true;
            total += a[x[idx-1]][i];
            if(idx == n-1){ // da tham n thanh pho
               
               update();
            }
            else{
                travel(idx+1);
            }
            d[i] = false;
            total -= a[x[idx-1]][i];
        }
    }
}

int main(){

    //khoi dong du lieu 
     initData();
    // Tim ket qua vi tri 1
    travel(1);
    output();
    
    // for(int i=0;i<n;i++){
    //     for(int j=0;j<n;j++){
    //         cout<<a[i][j]<<"\t";

    //     }
    //     cout<<endl;
    //  }

     cout<<"so luot chay : "<<count<<endl;
     //giai phong bo nho
     delete[] d;
     delete[] x;
     for(int i=0;i<n;i++){
        delete[] a[i];
     }
     delete[] a;
     system("pause");



}

// kĩ thuật khamen