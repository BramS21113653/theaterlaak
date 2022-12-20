import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Programmering } from "./components/Programmering";
import { Tickets } from "./components/Tickets";
import { Home } from "./components/Home";
import { Zaal } from "./components/Zaal";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/programmering',
    element: <Programmering />
  },
  {
    path: '/tickets',
    // requireAuth: true,
    element: <Tickets />
  },  
  {
    path: '/zaal',
    // requireAuth: true,
    element: <Zaal />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
