using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Graph_UI 
{
    public class Graph : ICloneable
    {
        private Dictionary<string, string> Vertexes = new Dictionary<string, string>();
        private char or;
        private char weight;
        private List<Edge> edges = new List<Edge>();
        public Dictionary<string, string> Get_Vertexes
        {
            get
            {
                return Vertexes;
            }
        }

        public char Get_or
        {
            get
            {
                return or;
            }
        }

        public char Get_weight
        {
            get
            {
                return weight;
            }
        }

        public Graph(char or, char weight)
        {
            this.or = or;
            this.weight = weight;
        }

        public Graph()
        {

        }

        public Graph(string file_name)
        {
            using (StreamReader file_In = new StreamReader(file_name, Encoding.GetEncoding(1251)))
            {
                string []inf = file_In.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                inf[0] = inf[0].Trim();
                inf[1] = inf[1].Trim();
                or = inf[0][inf[0].Length-1];
                weight = inf[1][inf[1].Length-1];
                if ((or == 'y' || or == 'n') && (weight == 'y' || weight == 'n'))
                {
                    String[] Vertex = file_In.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string elem in Vertex)
                    {
                        string[] s = elem.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        if (s.Length == 2)
                        {
                            Vertexes.Add(s[0], s[1].Trim('\n', '\r'));
                        }
                        else
                        {
                            Vertexes.Add(s[0], "");
                        }
                    }
                }
                else throw new Exception("Тип графа не распознан. Ошибка при считывании");
            }
        }

        //public Graph(Graph old)
        //{
        //    Vertexes = new Dictionary<string, string>(old.Vertexes);
        //}

        public object Clone()
        {
            Dictionary<string, string> v = new Dictionary<string, string>(Vertexes);
            return new Graph
            {
                Vertexes = new Dictionary<string, string>(v),
                or = this.or,
                weight = this.weight
            };
        }

        public bool Search_Key(string new_key)
        {
            if (Vertexes.ContainsKey(new_key)) return true;
            else return false;
        }

        public void In_File(string name_out)
        {

            using (StreamWriter file_out = new StreamWriter(name_out, false))
            {
                file_out.WriteLine("or: {0}, weight: {1}", or, weight);
                foreach (KeyValuePair<string, string> elem in Vertexes)
                    file_out.WriteLine("{0}:{1}", elem.Key, elem.Value);
            }
        }

        public void Add_Vertex(string name_vertex)
        {
            Vertexes.Add(name_vertex, "");
        }

        public void Remove_Vertex(string name_vertex)
        {
            Vertexes.Remove(name_vertex);
            List<string> ver_key = new List<string>(Vertexes.Keys);
            foreach (string elem in ver_key)
            {

                string[] str = Vertexes[elem].Split(';');
                string s = "";
                foreach (string elem_str in str)
                {
                    if ((elem_str.Contains("-- " + name_vertex)) || (elem_str.Contains("-> " + name_vertex)))
                    {
                        s = elem_str + ";";
                        Vertexes[elem] = Vertexes[elem].Replace(s, "");
                    }
                }
            }
        }

        public string Add_Arc(string Vertex1, string Vertex2, string weight1 = "")
        {
            if (or == 'y')
            {
                if (weight1 == "")
                {
                    if (!Vertexes[Vertex1].Contains(" -> " + Vertex2 + ";"))
                    {
                        Vertexes[Vertex1] = Vertexes[Vertex1] + " -> " + Vertex2 + ";";
                        return "Дуга успешно добавлена!";
                    }
                    else return "Дуга уже существует!";
                }
                else
                {
                    if (!Vertexes[Vertex1].Contains(" -> " + Vertex2 + ", "))
                    {
                        Vertexes[Vertex1] = Vertexes[Vertex1] + " -> " + Vertex2 + ", " + weight1 + ";";
                        return "Дуга успешно добавлена!";
                    }
                    else return "Дуга уже существует!";
                }
            }
            else if (or == 'n')
            {
                if (weight1 == "")
                {
                    if (!Vertexes[Vertex1].Contains(" -- " + Vertex2 + ";"))
                    {
                        Vertexes[Vertex1] = Vertexes[Vertex1] + " -- " + Vertex2 + ";";
                        Vertexes[Vertex2] = Vertexes[Vertex2] + " -- " + Vertex1 + ";";
                        return "Ребро успешно добавлено!";
                    }
                    else return "Ребро уже существует!";
                }
                else
                {
                    if (!Vertexes[Vertex1].Contains(" -- " + Vertex2 + ", "))
                    {
                        Vertexes[Vertex1] = Vertexes[Vertex1] + " -- " + Vertex2 + ", " + weight1 + ";";
                        Vertexes[Vertex2] = Vertexes[Vertex2] + " -- " + Vertex1 + ", " + weight1 + ";";
                        return "Ребро успешно добавлено!";
                    }
                    else return "Ребро уже существует!";
                }
            }
            else return "Ошибка при чтении графа!";
        }

        public string Remove_Arc(string Vertex1, string Vertex2)
        {
            if (or == 'y')
            {
                string[] str = Vertexes[Vertex1].Split(';');
                string s = "";
                foreach (string elem_str in str)
                {
                    if (elem_str.Contains("-> " + Vertex2))
                    {
                        s = elem_str + ";";
                        Vertexes[Vertex1] = Vertexes[Vertex1].Replace(s, "");
                        return "Дуга успешно удалена!";
                    }
                }
                return "Дуга не существует!";
            }
            if (or == 'n')
            {
                string[] str = Vertexes[Vertex1].Split(';');
                string s = "";
                foreach (string elem_str in str)
                {
                    if (elem_str.Contains("-- " + Vertex2))
                    {
                        s = elem_str + ";";
                        Vertexes[Vertex1] = Vertexes[Vertex1].Replace(s, "");
                    }
                }
                str = Vertexes[Vertex2].Split(';');
                s = "";
                foreach (string elem_str in str)
                {
                    if (elem_str.Contains("-- " + Vertex1))
                    {
                        s = elem_str + ";";
                        Vertexes[Vertex2] = Vertexes[Vertex2].Replace(s, "");
                        return "Ребро успешно удалено!";
                    }
                }
                return "Ребро не существует!";
            }
            else return "Ошибка при чтении графа!";
        }

        public List<string> vertex_one_degree()
        {
            List<string> v_one_degree = new List<string>();
            string[] s;
            foreach (KeyValuePair<string, string> elem in Vertexes)
            {
                s = elem.Value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (s.Length == 1) v_one_degree.Add(elem.Key);
            }
            return v_one_degree;
        }

        public string Search_vertex(string s)
        {
            s = s.Trim();
            s = s.Substring(3, s.Length-3);
            s = s.Trim();
            if (s.Contains(',')) return s.Substring(0, s.IndexOf(','));
            else return s;
        }

        public string Search_weight(string s)
        {
            s = s.Trim();
            return s.Substring(s.IndexOf(',')+1, s.Length- s.IndexOf(',')-1).Trim();
        }

        public List<string> indegree(string Vertex)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> list = new List<string>();
            string[] str;
            string s = "";
            foreach (KeyValuePair<string, string> elem_in_vertexes in Vertexes)
            {
                str = elem_in_vertexes.Value.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                if (!dic.Keys.Contains(elem_in_vertexes.Key)) dic.Add(elem_in_vertexes.Key, 0);
                foreach (string elem_in_str in str)
                {
                    s = Search_vertex(elem_in_str);
                    if (!dic.Keys.Contains(s)) dic.Add(s, 1);
                    else dic[s]++;
                }
            }
            foreach (string elem in dic.Keys)
            {
                if (dic[elem] < dic[Vertex]) list.Add(elem);
            }
            return list;
        }

        public void Symm_sub(Graph g2)
        {
            foreach (KeyValuePair<string, string> elem in g2.Vertexes)
            {
                if (!Vertexes.Keys.Contains(elem.Key))
                {
                    Vertexes.Add(elem.Key, elem.Value);
                }
                else
                {
                    HashSet<string> Set_cur = new HashSet<string>
                        (Vertexes[elem.Key].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                    HashSet<string> Set_g2 = new HashSet<string>
                        (elem.Value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries));
                    if (this.Get_weight == 'n')
                    {
                        Set_cur.SymmetricExceptWith(Set_g2);
                    }
                    else
                    {
                        string[] arr_g2 = Set_g2.ToArray();
                        string[] arr_cur = Set_cur.ToArray();
                        HashSet<string> S_cur = new HashSet<string>
                            (Set_cur.Where(n => Array.Find(arr_g2, x => x.Contains(n.Substring(0, n.IndexOf(',')))) == default(string)));
                        HashSet<string> S_g2 = new HashSet<string>
                            (Set_g2.Where(n => Array.Find(arr_cur, x => x.Contains(n.Substring(0, n.IndexOf(',')))) == default(string)));
                        Set_cur.IntersectWith(S_cur);
                        Set_cur.SymmetricExceptWith(S_g2);
                    }
                    Vertexes[elem.Key] = string.Join(";", Set_cur);
                    if (Vertexes[elem.Key] != "") Vertexes[elem.Key] += ";";
                }
            }
        }

        public Dictionary<string, int> Dijkstra(string v0)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();   // массив длин путей
            foreach (string elem in Vertexes.Keys)
                d.Add(elem, int.MaxValue);

            Dictionary<string, string> p = new Dictionary<string, string>();  //предки
            foreach (string elem in Vertexes.Keys)
               p.Add(elem, "");

            Dictionary<string, bool> used = new Dictionary<string, bool>();   // закрашена ли вершина
            foreach (string elem in Vertexes.Keys)
                used.Add(elem, false);

            string v;
            d[v0] = 0;
            p[v0] = "_";

            for(int i = 0; i < Vertexes.Count; i++)
            {
                v = "";
                foreach (string j in Vertexes.Keys)
                {
                    if (!used[j] && (v == "" || d[j] < d[v]))
                    {
                        v = j;
                    }
                }
                if (d[v] == int.MaxValue) break;
                used[v] = true;

                string[] s = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string k in s)
                {
                    if (k.Substring(4, k.IndexOf(',') - 4) != v0)
                    {
                        int w = Convert.ToInt32(k.Substring(k.IndexOf(',') + 1));
                        if (d[v] + w < d[k.Substring(4, k.IndexOf(',') - 4)])
                        {
                            d[k.Substring(4, k.IndexOf(',') - 4)] = d[v] + w;
                            p[k.Substring(4, k.IndexOf(',') - 4)] = v;
                        }
                    }
                }
            }
            return d;
        }

        public bool Bfs(string v0)
        {
            Dictionary<string, bool> used = new Dictionary<string, bool>();
            Queue<string> q = new Queue<string>();
            foreach (string elem in Vertexes.Keys)
            {
                used.Add(elem, false);
            }

            used[v0] = true;
            q.Enqueue(v0);

            while (q.Count != 0)
            {
                v0 = q.Dequeue();
                if (Vertexes[v0] == "") return false;
                else
                {
                    string[] s = Vertexes[v0].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s_elem in s)
                    {
                        string str = Search_vertex(s_elem);
                        if (!used[str])
                        {
                            used[str] = true;
                            q.Enqueue(str);
                        }
                    }
                    if (q.Count == Vertexes.Count - 1) return true;
                    else return false;
                }
            }
            return false;
        }

        public List<string> II_33()
        {
            List<string> list = new List<string>();
            foreach (string elem in Vertexes.Keys)
            {
                if (Bfs(elem)) list.Add(elem);
            }
            return list;
        }

        public int Dfs(string v, Dictionary<string, bool> used)
        {
            int usedVertexes = 1;
            used[v] = true;
            string[] s = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string k in s)
            {
                string k_v = Search_vertex(k);
                if (!used[k_v])
                usedVertexes += Dfs(k_v, used);
            }
            return usedVertexes;
        }

        public int Dfs(string v, string v0, Dictionary<string, bool> used)
        {
            int usedVertexes = 1;
            used[v] = true;
            string[] s = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string k in s)
            {
                string k_v = Search_vertex(k);
                if (!used[k_v] && k_v != v0)
                    usedVertexes += Dfs(k_v, v0, used);
            }
            return usedVertexes;
        }

        public List<string> II_21()
        {
            Dictionary<string, bool> used = new Dictionary<string, bool>();
            List<string> res = new List<string>();

            foreach (string elem in Vertexes.Keys)
            {
                used.Add(elem, false);
            }

            if (Dfs(Vertexes.Keys.First(), used) != Vertexes.Count) return res;

            foreach (string elem in Vertexes.Keys)
            {
                used[elem] = false;
            }

            int cnt = 0;
            foreach (string elem in Vertexes.Keys)
            {
                string[] s = Vertexes[elem].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                cnt += s.Length; 
            }
            cnt /= 2;
            foreach (string elem in Vertexes.Keys)
            {
                string[] s = Vertexes[elem].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (cnt - s.Length + 1 == Vertexes.Count - 1)
                {
                    if (Dfs(Search_vertex(s[0]), elem, used) == Vertexes.Count - 1)
                    {
                        res.Add(elem);
                    }
                    foreach (string v in Vertexes.Keys)
                    {
                        used[v] = false;
                    }
                }
            }
            return res;
        }

        public void Kruskal(Graph tree_g)
        {
            foreach (string elem in Vertexes.Keys)
            {
                tree_g.Vertexes.Add(elem, "");
            }

            Dictionary<string, int> g = new Dictionary<string, int>();
            foreach (string v1 in Vertexes.Keys)
            {
                string[] s_v = Vertexes[v1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in s_v)
                {
                    string v2 = Search_vertex(str);
                    int m = int.Parse(Search_weight(str));
                    if (!g.Keys.Contains(v2 + "-" + v1)) g.Add(v1 + "-" + v2, m);
                }
            }

            g = g.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            Dictionary<string, int> tree_id = new Dictionary<string, int>();
            int i = 1;
            foreach (string elem in Vertexes.Keys)
            {
                tree_id.Add(elem, i);
                ++i;
            }

            foreach(string arc in g.Keys)
            {
                string a = arc.Substring(0, arc.IndexOf("-"));
                string b = arc.Substring(arc.IndexOf("-") + 1, arc.Length - arc.IndexOf("-") - 1);
                int l = g[arc];
                if (tree_id[a] != tree_id[b])
                {
                    tree_g.Add_Arc(a, b, l.ToString());
                    int old_id = tree_id[b];
                    int new_id = tree_id[a];
                    foreach (string cur_id in Vertexes.Keys)
                    {
                        if (tree_id[cur_id] == old_id)
                            tree_id[cur_id] = new_id;
                    }
                }
            }
        }

        public List<string> Ford_Bellman()
        {
            Dictionary<string, int> edge = new Dictionary<string, int>();
            foreach (string v1 in Vertexes.Keys)
            {
                string[] s_v = Vertexes[v1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in s_v)
                {
                    string v2 = Search_vertex(str);
                    int m = int.Parse(Search_weight(str));
                    edge.Add(v1 + "-" + v2, m);
                }
            }

            

            Dictionary<string, long> d = new Dictionary<string, long>();
            Dictionary<string, string> p = new Dictionary<string, string>();
            foreach (string v1 in Vertexes.Keys)
            {
                d.Add(v1, int.MaxValue);
                p.Add(v1, "");
            }

            string x = "";
            foreach (string v in Vertexes.Keys)
            {
                x = "";
                foreach (string e in edge.Keys)
                {
                    string a = e.Substring(0, e.IndexOf("-"));
                    string b = e.Substring(e.IndexOf("-") + 1, e.Length - e.IndexOf("-") - 1);
                    int l = edge[e];
                    if (d[b] > d[a] + l)
                    {
                        d[b] = Math.Max(int.MinValue, d[a] + l);
                        p[b] = a;
                        x = b;
                    }
                }
            }

            List<string> path = new List<string>();
            if (x == "") return path;
            else
            {
                string y = x;
                for (int i = 0; i < Vertexes.Count; ++i)
                    y = p[y];
                for (string cur = y; ; cur = p[cur])
                {
                    path.Add(cur);
                    if (cur == y && path.Count > 1) break;
                }
                path.Reverse();
                return path;
            }

        }

        public int Floyd(string v, string u, Dictionary<string, Dictionary<string, string>> p, List<string> new_path)
        {
            p.Clear();
            Dictionary<string, Dictionary<string, int>> d = new Dictionary<string, Dictionary<string, int>>();
            foreach (string v1 in Vertexes.Keys)
            {

                string[] s_v = Vertexes[v1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> local_d = new Dictionary<string, int>();
                Dictionary<string, string> local_p = new Dictionary<string, string>();

                foreach (string str in s_v)
                {
                    string v2 = Search_vertex(str);
                    int m = int.Parse(Search_weight(str));
                    local_d.Add(v2, m);
                    local_p.Add(v2, v2);
                }
                local_d.Add(v1, 0);
                local_p.Add(v1, "");
                foreach (string v2 in Vertexes.Keys)
                {
                    if (!local_d.Keys.Contains(v2))
                    {
                        local_d.Add(v2, int.MaxValue);
                        local_p.Add(v2, "");
                    }
                }
                d.Add(v1, local_d);
                p.Add(v1, local_p);
            }


            foreach (string k in Vertexes.Keys)
            {
                foreach (string i in Vertexes.Keys)
                {
                    foreach (string j in Vertexes.Keys)
                    {
                        if (d[i][k] < int.MaxValue && d[k][j] < int.MaxValue && d[i][k] + d[k][j] < d[i][j])
                        {
                            d[i][j] = Math.Min(d[i][j], d[i][k] + d[k][j]);
                            p[i][j] = p[i][k];
                        }
                    }
                }
            }
            if (d[v][u] != int.MaxValue)
            {
                string c = v;
                while (c != u)
                {
                    new_path.Add(c);
                    c = p[c][u];
                }
                new_path.Add(u);
            }
            return d[v][u];

        }

        public void IVb_22(string v, string u, int k, SortedDictionary<int, List<string>> path)
        {
            Dictionary<string, Dictionary<string, string>> p = new Dictionary<string, Dictionary<string, string>>(); //матрица предков
            List<string> new_path = new List<string>(); // новый кратчайший путь
            int min = int.MaxValue;


            Dictionary<string, int> edge = new Dictionary<string, int>(); //все ребра графа
            foreach (string v1 in Vertexes.Keys)
            {
                string[] s_v = Vertexes[v1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in s_v)
                {
                    string v2 = Search_vertex(str);
                    int m = int.Parse(Search_weight(str));
                    edge.Add(v1 + "-" + v2, m);
                }
            }

            min = Floyd(v, u, p, new_path); //наименьший путь
            if (min != int.MaxValue)
            {
                string strJoin = string.Join(" ", new_path);
                if (!path.Keys.Contains(min))
                {
                    List<string> list = new List<string>();
                    list.Add(strJoin);
                    path.Add(min, list);
                }
                List<string> shortest_path = new List<string>(new_path); //кратчайший путь, который юзается в цикле while
                int res = 0;
                min = int.MaxValue;
                string node = shortest_path[0];
                int cnt = 0;
                while (node != u)
                {
                    string arc = shortest_path[cnt] + "-" + shortest_path[cnt + 1];
                    int arc_m = edge[arc];
                    Remove_Arc(shortest_path[cnt], shortest_path[cnt + 1]);
                    node = shortest_path[++cnt];
                    new_path = new List<string>(); // потенциальные кратчайший путь
                    min = Floyd(v, u, p, new_path);


                    if (min != int.MaxValue)
                    {
                        strJoin = string.Join(" ", new_path);
                        List<string> list = new List<string>();
                        list.Add(strJoin);
                        if (!path.Keys.Contains(min))
                        {

                            path.Add(min, list);
                            IVb_22(v, u, k, path);
                        }
                        else if (path.Keys.Contains(min) && !path[min].Contains(strJoin))
                        {
                            path[min].Add(strJoin);
                            IVb_22(v, u, k, path);
                        }
                    }


                    string[] two_vert = arc.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    Add_Arc(two_vert[0], two_vert[1], arc_m.ToString());
                }
            }
        }

        private List<string> Search_Adj(string v)
        {
            List<string> adj_v = new List<string>();
            string[] adj = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string adj_elem in adj)
            {
                adj_v.Add(Search_vertex(adj_elem));
            }
            return adj_v;
        }

        private string Search_Source(List<string> list_sources)
        {
            Add_Vertex("s");
            foreach (string v in list_sources)
            {
                int a = edges.Where(x => x.V == v).Sum(x => x.W);
                Add_Arc("s", v, a.ToString());
                edges.Add(new Edge("s", v, a));
            }
            return "s";
        }

        private string Search_Sink(List<string> list_sinks)
        {
            Add_Vertex("t");
            foreach (string v in list_sinks)
            {
                int a = edges.Where(x => x.U == v).Sum(x => x.W);
                Add_Arc(v, "t", a.ToString());
                edges.Add(new Edge(v, "t", a));
            }
            return "t";
        }

        public List<Edge> Get_edge()
        {
            List<Edge> edges = new List<Edge>();
            foreach (string v in Vertexes.Keys)
            {
                string[] adj = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string elem in adj)
                {
                    edges.Add(new Edge(v, Search_vertex(elem), Convert.ToInt32(Search_weight(elem))));
                }
            }
            return edges;
        }

        public int Ford_Fulkerson(string v, string sink, int cmin, Dictionary<string, bool> visited, Dictionary<string, List<string>> full_adj_list)
        {
            if (v == sink)
                return cmin;
            visited[v] = true;
            foreach (string u in full_adj_list[v])
            {
                bool inverse_edge = false;
                Edge edge = edges.Single(x => (x.V == v && x.U == u) || (x.U == v && x.V == u));
                if (u == edge.U)
                    inverse_edge = false;
                else if (u == edge.V)
                    inverse_edge = true;
                if ((!visited[u] && inverse_edge == false && edge.Flow < edge.W) || (!visited[u] && inverse_edge == true && edge.Flow > 0 && edge.Flow < edge.W))
                {
                    int delta = Ford_Fulkerson(u, sink, cmin < edge.W - edge.Flow ? cmin : edge.W - edge.Flow, 
                        new Dictionary<string, bool>(visited), full_adj_list);
                    if (delta > 0)
                    {
                        if (!inverse_edge)
                            edge.Flow += delta;
                        else
                            edge.Flow -= delta;
                        return delta;
                    }
                }
                else if (!visited[u] && inverse_edge == true && edge.Flow > 0 && edge.Flow == edge.W)
                {
                    int delta = Ford_Fulkerson(u, sink, cmin < edge.Flow ? cmin : edge.Flow, new Dictionary<string, bool>(visited), full_adj_list);
                    if (delta > 0)
                    {
                        edge.Flow -= delta;
                        return delta;
                    }
                }
            }
            return 0;
        }

        public int Max_flow()
        {
            List<string> list_sinks = new List<string>();
            HashSet<string> set_sources = new HashSet<string>(Vertexes.Keys);
            edges = new List<Edge>(Get_edge());
            foreach (string v in Vertexes.Keys)
            {
                HashSet<string> adj = new HashSet<string>(Search_Adj(v));
                if (adj.Count == 0) list_sinks.Add(v);
                set_sources.ExceptWith(adj);
            }

            List<string> list_sources = set_sources.ToList(); 
            string sink = "";
            string source = "";

            if (list_sinks.Count == 0 || list_sources.Count == 0) return -1;
            if (list_sinks.Count == 1) sink = list_sinks[0];
            else sink = Search_Sink(list_sinks);
            if (list_sources.Count == 1) source = list_sources[0];
            else source = Search_Source(list_sources);

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (string v in Vertexes.Keys)
            {
                visited.Add(v, false);
            }

            Dictionary<string, List<string>> full_adj_list = new Dictionary<string, List<string>>();
            foreach (string v in Vertexes.Keys)
            {
                full_adj_list.Add(v, Search_Adj(v));
            }
            foreach (string v in Vertexes.Keys)
            {
                if (v != source && v != sink)
                    foreach (string v_ in Vertexes.Keys)
                    {
                        if (v != v_ && Search_Adj(v_).IndexOf(v) != -1 && v_ != sink)
                            full_adj_list[v].Add(v_);
                    }
            }

            int max_flow = 0;
            int local_flow = Ford_Fulkerson(source, sink, int.MaxValue, new Dictionary<string, bool>(visited), full_adj_list);
            while (local_flow != 0)
            {
                max_flow += local_flow;
                local_flow = Ford_Fulkerson(source, sink, int.MaxValue, new Dictionary<string, bool>(visited), full_adj_list);
            }

            foreach (Edge e in edges)
                e.Flow = 0;

            return max_flow;
        }
    }
}
