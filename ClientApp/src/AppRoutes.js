import { Tickets } from "./components/Tickets";
import { Account } from "./components/Account";
import { Home } from "./components/Home";
import { Programmering } from "./components/Programmering";
import { Zaal } from "./components/Zaal"

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/tickets',
    element: <Tickets />
  },
  {
    path: '/account',
    element: <Account />
  },
  {
    path: '/programmering',
    element: <Programmering />
  },
  {
    path: '/zaal-huren',
    element: <Zaal />
  }
];

export default AppRoutes;
