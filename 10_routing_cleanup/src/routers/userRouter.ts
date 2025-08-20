import { Router } from 'express';
import * as userController from '../controllers/users.ts';

const router = Router();

// USERS routes
router.get('/', userController.getUsers);
router.post('/', userController.createUser);
router.get('/:id', userController.getUserById);
router.put('/:id', userController.updateUser);
router.delete('/:id', userController.deleteUser);

export default router;
