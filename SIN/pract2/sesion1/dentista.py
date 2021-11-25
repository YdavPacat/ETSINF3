import numpy as np
T=np.array([[0,0,0,.576],[0,0,1,.008],[0,1,0,.144],
            [0,1,1,.072],[1,0,0,.064],[1,0,1,.012],
            [1,1,0,.016],[1,1,1,.108]])
Pc1 = np.sum(T[np.where(T[:,1]==1)[0],-1])
Pd1 = np.sum(T[np.where(T[:,0]==1)[0],-1]) 

Pd1c1 = np.sum(T[np.where((T[:,0]==1)&(T[:,1]==1))[0],-1])
Pd1Dc1 = Pd1c1/Pc1

Pc1Dd1 = Pc1 * (Pd1Dc1 / Pd1)
print("La probabilidad de caries si hay dolor es de %.2f%c" % (Pc1Dd1 * 100, chr(37)))