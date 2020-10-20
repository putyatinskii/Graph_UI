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
        Dictionary<string, string> Vertexes = new Dictionary<string, string>();
        char or;
        char weight;
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
                String []inf = file_In.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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

            Dictionary<string, string> p = new Dictionary<string, string>();   // массив длин путей
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
            d[v0] = int.MinValue;
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

        public int dfs(string v, Dictionary<string, bool> used)
        {
            int usedVertexes = 1;
            used[v] = true;
            string[] s = Vertexes[v].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string k in s)
            {
                usedVertexes += dfs(Search_vertex(k), used);
            }
            return usedVertexes;
        }

        public void dfs_cycle(string v)
        {

        }

        public void II_21()
        {
            Dictionary<string, bool> used = new Dictionary<string, bool>();
            foreach (string elem in Vertexes.Keys)
            {
                used.Add(elem, false);
            }
            bool a = false;
            foreach (string elem in Vertexes.Keys)
            {
                if (Vertexes.Count == dfs(elem, used)) a = true;
                if (a)
                {

                }
                foreach (string v in Vertexes.Keys)
                {
                    used[v] = false;
                }
            }
        }
    }
}
