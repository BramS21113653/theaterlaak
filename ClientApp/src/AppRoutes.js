import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Programmering } from "./components/Programmering";
import { Tickets } from "./components/Tickets";
import { Home } from "./components/Home";
import { Zaal } from "./components/Zaal";
import { Groepen } from "./components/Groepen";
import { ApplicationUser } from './components/ApplicationUser';

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
  {
    path: '/groep',
    // requireAuth: true,
    element: <Groepen />
  },
  {
    path: '/applicationuser',
    // requireAuth: true,
    element: <ApplicationUser />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
