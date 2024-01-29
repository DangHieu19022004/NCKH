#include <bits/stdc++.h>

using namespace std;

map<string, vector<pair<string, int>>> Mang;

void Them() {
    Mang["Ha Noi"].push_back({"Hai Phong", 100});
    Mang["Hai Phong"].push_back({"Ha Noi", 100});
    Mang["Ha Noi"].push_back({"Hai Duong", 50});
    Mang["Hai Duong"].push_back({"Ha Noi", 50});
    Mang["Hai Phong"].push_back({"Hai Duong", 70});
    Mang["Hai Duong"].push_back({"Hai Phong", 70});
    Mang["Hai Phong"].push_back({"Ho Chi Minh", 90});
    Mang["Ho Chi Minh"].push_back({"Hai Phong", 90});
    Mang["Ho Chi Minh"].push_back({"Ca Mau", 300});
    Mang["Ca Mau"].push_back({"Ho Chi Minh", 300});
    Mang["Ho Chi Minh"].push_back({"Can Tho", 200});
    Mang["Can Tho"].push_back({"Ho Chi Minh", 200});
}

const int INF = 1e9;
map<string, string> pre;

void BatDauTT(map<string, long long> &KhoangCach, string start){
    KhoangCach["Hai Phong"] = INF;
    KhoangCach["Hai Duong"] = INF;
    KhoangCach["Ho Chi Minh"] = INF;
    KhoangCach["Ca Mau"] = INF;
    KhoangCach["Can Tho"] = INF;
    KhoangCach["Ha Noi"] = INF;
    KhoangCach[start] = 0;
}

void dijkstra(string start, string end) {
    map<string, long long> KhoangCach;
    BatDauTT(KhoangCach, start);
    priority_queue<pair<long long, string>, vector<pair<long long, string>>, greater<pair<long long, string>>> KC_Dinh;
    KC_Dinh.push({0, start});
    vector<string> ThuTuDuyet;
    while (!KC_Dinh.empty()) {
        pair<long long, string> top = KC_Dinh.top();
        KC_Dinh.pop();
        string Dinh_Dang_Xet = top.second;
        long long khoangCach = top.first;
        if (khoangCach > KhoangCach[Dinh_Dang_Xet]) continue;
        ThuTuDuyet.push_back(Dinh_Dang_Xet);
        for (auto it : Mang[Dinh_Dang_Xet]) {
            string Dich = it.first;
            long long kc = it.second;
            if (KhoangCach[Dich] > KhoangCach[Dinh_Dang_Xet] + kc) {
                KhoangCach[Dich] = KhoangCach[Dinh_Dang_Xet] + kc;
                pre[Dich] = Dinh_Dang_Xet;
                KC_Dinh.push({KhoangCach[Dich], Dich});
            }
        }
    }
    for (const string& city : ThuTuDuyet) {
        cout << city << ":" << KhoangCach[city] << ' ';
    }
    cout << endl;
    if(KhoangCach[end] == INF){
        cout << "Khong co duong di tu " << start << " den " << end << endl;
    }else{
        vector<string> DuongDi;
        string Dich = end;
        while(Dich != start){
            DuongDi.push_back(Dich);
            Dich = pre[Dich];
        }
        DuongDi.push_back(start);
        reverse(DuongDi.begin(), DuongDi.end());
        cout << "Duong di tu " << start << " den " << end << ": ";
        for(int i = 0; i < DuongDi.size(); i++){
            cout << DuongDi[i];
            if(i < DuongDi.size() - 1){
                cout << " -> ";
            }
        }
        cout << endl;
    }
}

int main() {
    Them();
    string start, end;
    cout << "Nhap ten thanh pho bat dau: ";
    getline(cin, start);
    cout << "Nhap ten thanh pho ket thuc: ";
    getline(cin, end);
    dijkstra(start, end);
    return 0;
}