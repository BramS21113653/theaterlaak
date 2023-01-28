import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Programmering } from "./components/Programmering";
import { Tickets } from "./components/Tickets";
import { Home } from "./components/Home";
import { Zaal } from "./components/Zaal";
import { GroepenAdmin } from "./components/GroepenAdmin";
import { ApplicationUserAdmin } from './components/ApplicationUserAdmin';
import { ZaalAdmin } from './components/ZaalAdmin';
import { AdminPanel } from './components/AdminPanel';
import { Betaling } from './components/Betaling';

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
    path: '/groepenadmin',
    // requireAuth: true,
    element: <GroepenAdmin />
  },
  {
    path: '/applicationuseradmin',
    // requireAuth: true,
    element: <ApplicationUserAdmin />
  },
  {
    path: '/adminpanel',
    // requireAuth: true,
    element: <AdminPanel />
  },
  {
    path: '/zaaladmin',
    // requireAuth: true,
    element: <ZaalAdmin />
  },
  {
    path: '/betaling',
    // requireAuth: true,
    element: <Betaling />
  },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
