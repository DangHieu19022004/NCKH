#include <bits/stdc++.h>
using namespace std;
 
using ll = long long;
 
const int maxn = 100001;
int n, m, s, t;
vector<pair<int, int>> adj[maxn];
 
void nhap(){
	cin >> n >> m >> s >> t; //nhap cả t - đích
	for(int i = 0; i < m; i++){
		int x, y, w; cin >> x >> y >> w;
		adj[x].push_back({y, w});
		adj[y].push_back({x, w});
	}
}
 
const int INF = 1e9;
int pre[maxn];
 
void dijkstra(int s){
	//Mang luu khoang cach duong di
	vector<ll> d(n + 1, INF);
	d[s] = 0;
	priority_queue<pair<int, int>, vector<pair<int, int>> , greater<pair<int,int>>> Q;
	//{khoang cach, dinh}
	Q.push({0, s});
	while(!Q.empty()){
		//Chọn ra đỉnh có khoảng cách từ s nhỏ nhất 
		pair<int, int> top = Q.top(); Q.pop();
		int u = top.second;
		int kc = top.first;
		if(kc > d[u]) continue;
		//Relaxtion : Thông qua đỉnh u đã biết khoảng cách ngắn nhất tính từ S, cập
		//nhật khoảng cách với các đỉnh kề với u
		for(auto it : adj[u]){
			int v = it.first;
			int w = it.second;
			if(d[v] > d[u] + w){
				d[v] = d[u] + w;
				// Lưu lại đỉnh trước đó của v
				pre[v] = u;
				Q.push({d[v], v});
			}
		}
	}
	//In ra quãng đường đi ngắn nhất từ s đến t
	for(int i = 1; i <= n; i++){
		cout << d[i] << ' ';
	}
	cout << endl << endl;
	//In ra đường đi ngắn nhất từ s đến t
	// In thứ tự các đỉnh trên đường đi từ s đến t
    if (d[t] == INF) {
        cout << "Khong co duong di tu " << s << " den " << t << endl;
    } else {
		vector<int> path;
		int v = t;
		while (v != s)
		{
			path.push_back(v);
			v = pre[v];
		}
		path.push_back(s);
		reverse(path.begin(), path.end());

		cout << "Duong di tu " << s << " den " << t << ": ";
        for (int i = 0; i < path.size(); i++) {
            cout << path[i];
            if (i < path.size() - 1) {
                cout << " -> ";
            }
        }
        cout << endl;
    }
}
 
 
int main(){
	freopen("input.txt", "r", stdin);
    freopen("output.txt", "w", stdout);
	ios::sync_with_stdio(false);
	cin.tie(nullptr);
	nhap();
	dijkstra(s);
}